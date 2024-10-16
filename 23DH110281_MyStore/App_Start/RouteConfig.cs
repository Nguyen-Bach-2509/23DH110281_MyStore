using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _23DH110281_MyStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 new[] { "_23DH110281_MyStore.Controllers" }
=======
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
>>>>>>> bc6b069f20bda10803808f451c423a4c2cf8408e
            );
        }
    }
}
