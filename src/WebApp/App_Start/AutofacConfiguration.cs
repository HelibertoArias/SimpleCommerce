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

            // Register your Web controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //-> Services
            // builder.RegisterType<ProductService>().As<IProductService>();
            //builder.RegisterType<ProductServiceMemory>().As<IProductService>();

            builder.Register(c => GetService()).As<IProductService>();

            //Register repositories and services.
            Container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));

        }

        public static IProductService GetService()
        {

            if( System.Web.HttpContext.Current.Session["InMemory"] != null)
                return new ProductService();
            else
               return new ProductServiceMemory();

        }


    }

}