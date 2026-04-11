using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace dipendenti_management
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/",
                defaults: new { controller = "Default", action = "Index" }
            );

            routes.MapRoute(
                name: "Dashboard",
                url: "{controller}/{action}/",
                defaults: new { controller = "Default", action = "Index" }
            );
        }
    }
}
