using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapNavigationRoute("Home", "", new {controller = "Home", action = "Index"});
            routes.MapNavigationRoute("About", "about", new {controller = "Home", action = "About"});
            routes.MapNavigationRoute("Contact", "contact", new {controller = "Home", action = "Contact"});
        }
        
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            AddBundles();
        }

        static void AddBundles()
        {
            var jsBundle = new Bundle("~/js", new NoTransform());
            jsBundle.AddFile("~/Scripts/jquery-1.7.2.min.js");
            jsBundle.AddFile("~/Scripts/bootstrap.min.js");
            BundleTable.Bundles.Add(jsBundle);

            var cssBundle = new Bundle("~/css", new NoTransform());
            cssBundle.AddFile("~/Content/bootstrap.min.css");
            BundleTable.Bundles.Add(cssBundle);

            var responsiveCssBundle = new Bundle("~/rcss", new NoTransform());
            responsiveCssBundle.AddFile("~/Content/bootstrap-responsive.min.css");
            BundleTable.Bundles.Add(responsiveCssBundle);
        }
    }
}