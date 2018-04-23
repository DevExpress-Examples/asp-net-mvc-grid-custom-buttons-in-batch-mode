' Developer Express Code Central Example:
' GridView - A simple Batch Editing implementation
' 
' This example illustrates a simple implementation of a new ASPxGridView Batch
' Editing Mode functionality available starting with version 13.2:
' ASP.NET
' WebForms & MVC: GridView Batch Edit (What's new in 13.2)
' (https://community.devexpress.com/blogs/aspnet/archive/2013/12/16/asp-net-webforms-amp-mvc-gridview-batch-edit-what-39-s-new-in-13-2.aspx)
' This
' example is a standalone DB-independent solution of the online Batch Editing
' (http://demos.devexpress.com/MVCxGridViewDemos/Editing/BatchEditing) demo. Refer
' to the demo's Description for more information.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5046

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace DXWebApplication1
	' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	' visit http://go.microsoft.com/?LinkId=9394801

	Public Class MvcApplication
		Inherits System.Web.HttpApplication

		Public Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
			filters.Add(New HandleErrorAttribute())
		End Sub

		Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
			routes.IgnoreRoute("{resource}.ashx/{*pathInfo}")

			routes.MapRoute("Default", "{controller}/{action}/{id}", New With {Key .controller = "Home", Key .action = "Index", Key .id = UrlParameter.Optional}) ' Parameter defaults -  URL with parameters -  Route name

		End Sub
		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()

			RegisterGlobalFilters(GlobalFilters.Filters)
			RegisterRoutes(RouteTable.Routes)

			ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()
		End Sub
	End Class
End Namespace