namespace OpenLeague.Web
{
    using System.Reflection;
    using System.Web.Mvc;

    using Autofac;
    using Autofac.Integration.Mvc;

    using OpenLeague.Model.Services;

    public static class Bootstrapper
    {
        public static void Compose()
        {
            SetAutofacContainer(); 
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();

            // 1. By default, register all the controllers. You need to do this as a minimum, because we are replacing the default
            //    DependencyResolver that comes with ASP.NET MVC
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // 2. This code may look weird, however all it does is:
            //    Look at the assembly that contains DeviceRepository and 
            //    anything that ends in Repository, 
            //    for the callers that require the interface, 
            //    create one per HTTP request.
            builder.RegisterAssemblyTypes(Assembly.Load("OpenLeague.Persistence")).Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerHttpRequest();

            builder.RegisterAssemblyTypes(typeof(ContestManagementService).Assembly).Where(
                t => t.Name.EndsWith("ManagementService")).AsImplementedInterfaces().InstancePerHttpRequest();

            // 3. Compose the IoC container
            var container = builder.Build();

            // 4. Replace the ASP.NET MVC resolver with this one.
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}