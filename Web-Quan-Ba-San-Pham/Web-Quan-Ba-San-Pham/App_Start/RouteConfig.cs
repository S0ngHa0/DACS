﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_Quan_Ba_San_Pham
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[]{ "Web_Quan_Ba_San_Pham.Controllers" }
            );
            routes.MapRoute(
             name: "Cart",
             url: "gio-hang",
             defaults: new { controller = "Cart", action = "Index", alias = UrlParameter.Optional },
             namespaces: new[] { "Web_Quan_Ba_San_Pham.Controllers" }
         );
        }
    }
}
