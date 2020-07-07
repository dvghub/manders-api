using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace manders_api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "page",
                routeTemplate: "api/{controller}/{action}/{page}",
                defaults: new { page = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "day",
                routeTemplate: "api/{controller}/{action}/{day}",
                defaults: new { day = RouteParameter.Optional }
            );
        }
    }
}
