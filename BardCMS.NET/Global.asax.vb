﻿' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
' visit http://go.microsoft.com/?LinkId=9394802
Imports System.Web.Http
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    'Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
    '    filters.Add(New HandleErrorAttribute())
    'End Sub

    'Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
    '    routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

    '    routes.MapHttpRoute( _
    '        name:="DefaultApi", _
    '        routeTemplate:="api/{controller}/{id}", _
    '        defaults:=New With {.id = RouteParameter.Optional} _
    '    )

    '    routes.MapRoute( _
    '        name:="Default", _
    '        url:="{controller}/{action}/{id}", _
    '        defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional} _
    '    )
    'End Sub

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()

        'RegisterGlobalFilters(GlobalFilters.Filters)
        'RegisterRoutes(RouteTable.Routes)

        '    BundleTable.Bundles.RegisterTemplateBundles()

        AreaRegistration.RegisterAllAreas()

        WebApiConfig.Register(GlobalConfiguration.Configuration)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class
