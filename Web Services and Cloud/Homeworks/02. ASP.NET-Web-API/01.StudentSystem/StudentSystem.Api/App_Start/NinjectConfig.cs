using System;
using System.Web;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Web.Common;
using StudentSystem.Data;
using StudentSystem.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SourceControlSystem.Api.App_Start.NinjectConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SourceControlSystem.Api.App_Start.NinjectConfig), "Stop")]

namespace SourceControlSystem.Api.App_Start
{
    public static class NinjectConfig 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();
        
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
        
        private static void RegisterServices(IKernel kernel)
        {
            kernel
                .Bind<IStudentSystemDbContext>()
                .To<StudentSystemDbContext>()
                .InRequestScope();

            kernel.Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));

            kernel.Bind(b => b.From("StudentSystem.Services.Data")
                .SelectAllClasses()
                .BindDefaultInterface());
        }        
    }
}
