using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi2Book.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();


			//Using the power of URL routing, the framework will try to match the URLs of requests against this and other
			//routes.In this particular route, the framework will use the portion of the URL specified after api / to determine the
			//appropriate controller to activate. Assume you were to make either of the following calls against the service:
			/// api / tasks
			/// api / tasks / 123

			config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
