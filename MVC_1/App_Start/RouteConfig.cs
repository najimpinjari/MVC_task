using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes(); //for addition enable raouting its necesary  //attribute based raouting

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //first rauting
            routes.MapRoute
            (
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
                                                            //add here your action method name 
            );
            //second rauting
            routes.MapRoute
           (
               name: "Default1",
               url: "{controller}/{action}/{id}/{name}",
               defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
           
           );
        }
    }
}
