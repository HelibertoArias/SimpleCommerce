using Autofac.Integration.Mvc;
using SimpleCommerce.Service.Maps;
using SimpleCommerce.WebApp.App_Start;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Load map entity -> viewmodels
            AutomapperConfiguration.Configure();

            //--> Autofac
            AutofacConfiguration.Register();
        }
    }
}
