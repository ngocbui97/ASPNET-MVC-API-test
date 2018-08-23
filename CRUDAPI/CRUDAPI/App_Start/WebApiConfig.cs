using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CRUDAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
    // neu ko chi dinh them {action} tren template thi action se chi dc goi theo httpMethod va controler}
}
