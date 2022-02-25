using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _23FebMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Employee",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Employee", action = "DisplayAll", id = UrlParameter.Optional },
                         new { controller= "Employee", action = "AddEmployee"}
                         
           );
            routes.MapRoute(
               name: "DeleteEmployee",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Employee", action = "DeleteEmployee", id = UrlParameter.Optional }
                       


           );
            
        }
    }
}
