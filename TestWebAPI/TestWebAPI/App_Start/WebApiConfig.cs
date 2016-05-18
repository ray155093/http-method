using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TestWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 設定和服務

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DeleteApi",
                routeTemplate: "api/{controller}/{value}",
                defaults: new { name = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "InsertApi",
                routeTemplate: "api/{controller}/{value}",
                defaults: new { name = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "UpdateApi",
                routeTemplate: "api/{controller}/{id}/{value}",
                defaults: new { name = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
