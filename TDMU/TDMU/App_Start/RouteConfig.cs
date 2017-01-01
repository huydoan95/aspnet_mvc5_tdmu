using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TDMU
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Trang chủ",
                url: "home",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Tin tức",
                url: "news",
                defaults: new { controller = "News", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );
            routes.MapRoute(
                name: "our photos",
                url: "ourphoto",
                defaults: new { controller = "Photo", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );
            routes.MapRoute(
                name: "Chi tiết tin tức",
                url: "news/{url}.html",
                defaults: new { controller = "News", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Thông báo",
                url: "annoucement",
                defaults: new { controller = "Annoucement", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                  name: "Send Success",
                  url: "Success",
                  defaults: new { controller = "Contact", action = "Success", id = UrlParameter.Optional },
                  namespaces: new[] { "TDMU.Controllers" }
             );
            routes.MapRoute(
                  name: "Training Ologies",
                  url: "trainingologies",
                  defaults: new { controller = "TrainingOlogies", action = "Index", id = UrlParameter.Optional },
                  namespaces: new[] { "TDMU.Controllers" }
             );
            routes.MapRoute(
                name: "Chi tiết Thông báo",
                url: "annoucement/{url}.html",
                defaults: new { controller = "Annoucement", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Sự kiện",
                url: "event",
                defaults: new { controller = "Event", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết sự kiện",
                url: "event/{url}.html",
                defaults: new { controller = "Event", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            //upevent//
            routes.MapRoute(
                name: "Sự kiện hot",
                url: "upevent",
                defaults: new { controller = "UpEvent", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết sự kiện hot",
                url: "upevent/{url}.html",
                defaults: new { controller = "UpEvent", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );
            //End upevent//


            routes.MapRoute(
                name: "Slide",
                url: "slide",
                defaults: new { controller = "Slide", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết slide",
                url: "slide/{url}.html",
                defaults: new { controller = "Slide", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "About",
                url: "about",
                defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Calendar",
                url: "calendar",
                defaults: new { controller = "Calendar", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết Calendar",
                url: "calendar/{url}.html",
                defaults: new { controller = "Calendar", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "CDIO",
                url: "cdio",
                defaults: new { controller = "Cdio", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết CDIO",
                url: "cdio/{url}.html",
                defaults: new { controller = "Cdio", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Course",
                url: "course",
                defaults: new { controller = "Course", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết Course",
                url: "course/{url}.html",
                defaults: new { controller = "Course", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );
           

            routes.MapRoute(
                name: "faculties",
                url: "faculties",
                defaults: new { controller = "Faculties", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết faculties",
                url: "faculties/{url}.html",
                defaults: new { controller = "Faculties", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "administrative",
                url: "administrative",
                defaults: new { controller = "Administrative", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết administrative",
                url: "administrative/{url}.html",
                defaults: new { controller = "Administrative", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            
            //Center Start//
            routes.MapRoute(
                name: "center",
                url: "center",
                defaults: new { controller = "Center", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết center",
                url: "center/{url}.html",
                defaults: new { controller = "Center", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );
            //Center End//
            routes.MapRoute(
                name: "Work",
                url: "work",
                defaults: new { controller = "Work", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết work",
                url: "work/{url}.html",
                defaults: new { controller = "Work", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "blog",
                url: "blog",
                defaults: new { controller = "Blog", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiết Blog",
                url: "blog/{url}.html",
                defaults: new { controller = "Blog", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
               name: "Admission",
               url: "admission",
               defaults: new { controller = "Admission", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "TDMU.Controllers" }
           );

            routes.MapRoute(
                name: "Chi tiết Admission",
                url: "admission/{url}.html",
                defaults: new { controller = "Admission", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
               name: "Search",
               url: "search",
               defaults: new { controller = "Search", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "TDMU.Controllers" }
           );

            routes.MapRoute(
                name: "Chi tiết Search",
                url: "search/{url}.html",
                defaults: new { controller = "Search", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TDMU.Controllers" }
            );
        }
    }
}
