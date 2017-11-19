using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.ApplicationInsights;
using System.Web;
using System.Diagnostics;
using WebApp.Services;
using Repository.Pattern.UnitOfWork;
using WebApp.Models;

namespace WebApp.ErrorHandler
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AiHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext != null && filterContext.HttpContext != null && filterContext.Exception != null)
            {
                //If customError is Off, then AI HTTPModule will report the exception
                if (filterContext.HttpContext.IsCustomErrorEnabled)
                {
                    var ai = new TelemetryClient();
                    ai.TrackException(filterContext.Exception);
                }
                var st = new StackTrace(filterContext.Exception, true);
                var query = st.GetFrames()         // get the frames
                      .Select(frame => new UnHandledErrors
                      {                   // get the info
                          LineNumber = frame.GetFileLineNumber(),
                          MethodName = frame.GetMethod().ToString(),
                          ClassName = frame.GetMethod().DeclaringType.ToString()
                      }).FirstOrDefault();
                if (query != null)
                {
                    query.ErrorMessage = filterContext.Exception.Message;
                    query.ErrorDetail = filterContext.Exception.ToString();
                    query.ErrorCode = (byte)filterContext.HttpContext.Response.StatusCode;
                    IUnHandledErrorsService _errorService = DependencyResolver.Current.GetService<IUnHandledErrorsService>();
                    IUnitOfWorkAsync _unitOfWork = DependencyResolver.Current.GetService<IUnitOfWorkAsync>();
                    _errorService.Insert(query);
                    _unitOfWork.SaveChanges();
                }
            }

            //int code = filterContext.HttpContext.Response.StatusCode;
            base.OnException(filterContext);
            //throw new HttpException(code, filterContext.HttpContext.Response.Status);
        }
    }
}