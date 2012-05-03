<#
  This is the main build file
  more comments
  more comments
#>

framework "4.0"

properties {
  $msbuild = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"
  $makecert = "C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\makecert.exe"
  $configuration = "Release"
  $basepath = resolve-path .
  $toolspath = "$basePath\tools"
  $outpath = "$basePath\bin\$configuration"
  $subscription = [Guid]::Empty
  $storageaccount = ""
  $servicedns = ""
  $certificatethumb = ""
  $certificatename = "Open League Admin"

  if (test-path "$toolspath\environment.xml")
  {
      $environment = [xml] (cat "$toolspath\environment.xml")
      $subscription = $environment.environment.subscription
      $storageaccount = $environment.environment.storageaccount
      $servicedns = $environment.environment.servicedns
      $certificatethumb = $environment.environment.certificatethumb
  }

  $deploymentpackage = "$outpath\app.publish\OpenLeague.cloud.cspkg"
  $deploymentconfig = "$outpath\app.publish\ServiceConfiguration.Cloud.cscfg"
  $buildnumber = "#dev"
}

task default -depends Test

task Clean {
  del $outPath -force -recurse -erroraction SilentlyContinue
}

task Env {
  "----------------------------------------------------------------------"
  "Setting up your environment"
  "----------------------------------------------------------------------"

  do
  {
    $input = read-host "Azure Subscription Id: "
  } until([Guid]::TryParse($input, [ref] $subscription))

  $storageaccount = "devstorage{0}" -f [Guid]::NewGuid().ToString("N").Substring(0,13)
  $servicedns = "openleague{0}" -f [Guid]::NewGuid().ToString("N")

  $certificate = (ls cert:\LocalMachine\my | where {$_.Subject -eq "CN=$certificatename"})

  if (!$certificate)
  {
      $desktoppath = [Environment]::GetFolderPath("Desktop")
      exec { & "$makecert" -sky exchange -r -n "CN=$certificatename" -pe -a sha1 -len 2048 -sr LocalMachine -ss My "$desktoppath\OpenLeagueAdmin.cer" }
      $certificate = (ls cert:\LocalMachine\my | where {$_.Subject -eq "CN=$certificatename"})
  }

  $certificatethumb = $certificate.Thumbprint

  $environment = [xml] @"
                  <environment>
                    <subscription>$subscription</subscription>
                    <storageaccount>$storageaccount</storageaccount>
                    <servicedns>$servicedns</servicedns>
                    <certificatethumb>$certificatethumb</certificatethumb>
                  </environment>
"@

  $environment.Save("$toolspath\environment.xml");

  write-host "The management certificate has been saved on your desktop, make sure you import it into your azure account under Management Certificates before attempting a deployment" -foregroundcolor "magenta"
}

task Compile {
  mkdir "$outPath" -erroraction SilentlyContinue

  exec { & msbuild OpenLeague.sln /nologo /m:1 /nr:false /t:Build /v:M /fl /flp:LogFile="$outPath\msbuild.log;Verbosity=Normal" /p:Configuration=Release /p:OutputPath="$outPath" /p:StyleCopEnabled=true /p:StyleCopTreatErrorsAsWarnings=false }

#exec { & msbuild /nologo /t:Publish /v:M $basePath\src\OpenLeague.Cloud\OpenLeague.Cloud.ccproj /p:OutputPath="$outPath\"}
}

task Test -depends Compile {

}

task Prereq {
  if (!$subscription -or !$storageaccount -or !$servicedns -or !$certificatethumb)
  {
      "subscription:      {0}" -f $subscription.ToString()
      "storage account:   {0}" -f $storageaccount
      "service DNS:       {0}" -f $servicedns
      "certificate:       {0}" -f $certificatethumb
@"
No environment found.

To set up a new environment run:

    .\build.ps1 env

Or alternatively, on a build agent, pass all the parameters into the build command line:

    .\build.ps1 -properties @{subscription = 'value'; storageaccount = 'value'; servicedns = 'value'; certificatethumb = 'value'}

"@
    exit 1
  }
}

task Deploy -depends Prereq {
  "Build Number            :$buildnumber"
  "Deploying subscription  :$subscription"
  "Storage                 :$storageaccount"
  "Dns                     :$servicedns"
  "Certificate             :$certificatethumb`n"

  $certificate = (ls cert:\LocalMachine\My\$certificatethumb)

  $hostedservice = get-hostedservice -certificate $certificate -subscriptionid $subscription | where {$_.ServiceName -eq $servicedns}

  if(!$hostedservice)
  {
    "Creating the hosted service"
    new-hostedservice -servicename $servicedns -location "Anywhere Europe" -certificate $certificate -subscriptionid $subscription | get-operationstatus -waittocomplete
    "Created hosted service $servicedns"
  }

  $deployment = get-deployment staging -servicename $servicedns -certificate $certificate -subscriptionid $subscription

  if($deployment)
  {
    $deployment | set-deploymentstatus "Suspended" | get-operationstatus -waittocomplete
    "Suspended the Staging Environment"
    $deployment | remove-deployment | get-operationstatus -waittocomplete
    "Deleted the Staging Environment"
  }

  if(!(get-storageaccount -certificate $certificate -subscriptionid $subscription | where {$_.StorageAccountName -eq $storageaccount}))
  {
    "Creating the storage account"
    new-storageaccount -storageaccountname $storageaccount -location "Anywhere Europe" -subscriptionid $subscription -certificate $certificate | get-operationstatus -waittocomplete
    "Created the storage account"
  }

    "Creating deployment"
    get-hostedservice $servicedns -certificate $certificate -subscriptionid $subscription |
    new-deployment -slot "Staging" -package $deploymentpackage -configuration $deploymentconfig -label $buildnumber -storageservicename $storageaccount |
    get-operationstatus -waittocomplete
    "Created the deployment"

    "Starting deployment"
    get-hostedservice $servicedns -certificate $certificate -subscriptionid $subscription |
      get-deployment -slot staging |
      set-deploymentstatus "Running" |
      get-operationstatus -waittocomplete

  "Waiting for deployment to start"
  do
  {
    sleep 10
  }
  until ((get-deployment -slot staging -servicename $servicedns -certificate $certificate -subscriptionid $subscription).Status -eq "Running")

  "Waiting for all instances to start"
  do
  {
    sleep 10
  }
  while ((get-roleinstancestatus -servicename $servicedns -deploymentslot staging -certificate $certificate -subscriptionid $subscription).RoleInstances | where { $_.InstanceStatus -ne "Ready" })

  "Done!"
}

