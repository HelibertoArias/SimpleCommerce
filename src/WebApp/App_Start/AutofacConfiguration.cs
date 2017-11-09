using Autofac;
using Autofac.Integration.Mvc;
using SimpleCommerce.Repository;
using SimpleCommerce.Repository.Repositories.Interfaces;
using SimpleCommerce.Service;
using System.Web.Mvc;
using WebApp;

namespace SimpleCommerce.WebApp.App_Start
{
    public class AutofacConfiguration
    {
        public static IContainer Container { get; private set; }

        public static void Register()
        {
            var builder = new ContainerBuilder();
            // Register your Web API controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //-> Repositories
            //builder.RegisterType<ProductRepository>().As<IProductRepository>();
            //builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            ////builder.RegisterGeneric(typeof(IEntityBaseRepository<>))
            //    .As(typeof(IEntityBaseRepository<>)).InstancePerRequest();


            //-> UoW
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            //builder.RegisterType<DbFactory>().As<IDbFactory>();


            //-> Services
            // builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProductServiceMemory>().As<IProductService>();






            //Register repositories and services.
            Container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));

        }
    }

}