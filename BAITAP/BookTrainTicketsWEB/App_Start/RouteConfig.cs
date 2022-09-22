using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookTrainTicketsWEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            #region Điều hướng trang mặc định
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index"},
               namespaces: new string[] { "BookTrainTicketsWEB.Areas.Admin.Controllers" }
           ).DataTokens.Add("Area", "Admin");
            #endregion
        }
    }
}

