using E_CommerceWebSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace E_Ticaret
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
          /*  RouteTable.Routes.MapRoute(name: "default", url: "Home/Index", defaults: new { controller = "Home", action = "Index" });*/
        }
    }
}
