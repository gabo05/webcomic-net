using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ComicXKCD.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller="Comic", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Today",
                url: "Comic/Today",
                defaults: new { controller = "Comic", action = "Today" }
            );
            routes.MapRoute(
                name: "ComicNum",
                url: "Comic/Comic/{id}",
                defaults: new { controller = "Comic", action = "Comic" }
            );
            routes.MapRoute(
                name: "Comic",
                url: "comic/{id}",
                defaults: new { controller = "Comic", action = "Index" }
            );
        }
    }
}

