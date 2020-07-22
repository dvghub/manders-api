using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace manders_api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "page",
                routeTemplate: "api/{controller}/{action}/{page}",
                defaults: new { page = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "date",
                routeTemplate: "api/{controller}/{action}/{year}/{month}/{day}",
                defaults: new { year = RouteParameter.Optional, month = RouteParameter.Optional, day = RouteParameter.Optional }
            );
        }
    }
}
