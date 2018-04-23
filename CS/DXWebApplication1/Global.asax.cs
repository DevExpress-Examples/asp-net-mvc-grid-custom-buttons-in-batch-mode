// Developer Express Code Central Example:
// GridView - A simple Batch Editing implementation
// 
// This example illustrates a simple implementation of a new ASPxGridView Batch
// Editing Mode functionality available starting with version 13.2:
// ASP.NET
// WebForms & MVC: GridView Batch Edit (What's new in 13.2)
// (https://community.devexpress.com/blogs/aspnet/archive/2013/12/16/asp-net-webforms-amp-mvc-gridview-batch-edit-what-39-s-new-in-13-2.aspx)
// This
// example is a standalone DB-independent solution of the online Batch Editing
// (http://demos.devexpress.com/MVCxGridViewDemos/Editing/BatchEditing) demo. Refer
// to the demo's Description for more information.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5046

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DXWebApplication1 {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();
        }
    }
}