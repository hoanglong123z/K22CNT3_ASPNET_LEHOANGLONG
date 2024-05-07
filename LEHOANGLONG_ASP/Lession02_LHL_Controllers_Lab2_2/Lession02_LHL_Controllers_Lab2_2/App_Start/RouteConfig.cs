using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lession02_LHL_Controllers_Lab2_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LHLHome", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Show Product",
                url: "San-Pham/Danh-Sach-San-Pham",
                defaults: new { controller = "Product", action = "ShowProduct" }
            );
        }
    }
}
