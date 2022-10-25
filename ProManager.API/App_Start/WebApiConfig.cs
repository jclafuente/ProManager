using ProManager.API.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProManager.API
{
    /// <summary>
    /// Permite gestionar las configuraciones del WEBAPI
    /// </summary>
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            var enableCorsAttribute = new EnableCorsAttribute("*",
                "Origin, Content-Type, Accept",
                "GET, PUT, POST, DELETE, OPTION");

            config.EnableCors(enableCorsAttribute);

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.MessageHandlers.Add(new TokenValidationHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
