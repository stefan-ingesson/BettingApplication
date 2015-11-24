using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BettingApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
<<<<<<< HEAD

            config.Routes.MapHttpRoute(
name: "Api",
routeTemplate: "api/{controller}/{action}/{id}",
defaults: new { id = RouteParameter.Optional }
);
=======
>>>>>>> refs/remotes/origin/Api-Andreas
        }
    }
}
