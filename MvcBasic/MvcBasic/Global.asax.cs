using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MvcBasic.Models;
using System.Data.Entity;

namespace MvcBasic
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<MvcBasicContext>(new MvcBasicInitializer());

            // 以下にビューエンジンの無効化を追加
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new WebFormViewEngine());
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}
