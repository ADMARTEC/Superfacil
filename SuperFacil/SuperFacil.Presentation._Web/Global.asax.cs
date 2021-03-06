﻿using SuperFacil.Infraestructure.IoC;
using SuperFacil.Presentation._Web.AutoMapper;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SuperFacil.Presentation._Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);    
            DependencyResolver.SetResolver(IoC.Start());
            AutoMapperProfile.Register();
        }
    }
}
