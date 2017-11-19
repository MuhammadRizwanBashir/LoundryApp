using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApp.AutoMapper;

namespace WebApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfiguration.Configure();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
        }

        //protected void Application_Error()
        //{
        //    var error = Server.GetLastError();
        //    //Server.ClearError();
        //    //code to log error here
        //    var httpException = error as HttpException;
        //    //Response.StatusCode = httpException != null ? httpException.GetHttpCode() : (int)HttpStatusCode.InternalServerError;
        //    Response.TrySkipIisCustomErrors = true;
        //}
    }
}
