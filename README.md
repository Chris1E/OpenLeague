Welcome to the OpenLeague project.
=============================

OpenLeague is a Sports fixture management system.

## Prerequisites

* [Windows Azure PowerShell Cmdlets](http://wappowershell.codeplex.com/)
* Running PowerShell under .Net 4

To run PowerShell under .Net 4 you need to change its config file. The PowerShell config file can be found at $pshome\powershell.exe.config. If the file is not there just create it and add the following to it.

        <?xml version="1.0"?>
        <configuration>
            <startup useLegacyV2RuntimeActivationPolicy="true">
                <supportedRuntime version="v4.0.30319"/>
                <supportedRuntime version="v2.0.50727"/>
            </startup>
        </configuration>

## Setting up the environment for Windows Azure

> .\build.ps1 env

Type in your subscription id and then import the certificate that the build creates into your Windows Azure management certificate list.
The build script also creates the tools\environment.xml that contains all the environment variables needed for Azure deployment.

## Building the solution

> .\build.ps1

## Deploying to Azure

> .\build.ps1 deploy

