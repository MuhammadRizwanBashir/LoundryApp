using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ErrorsController : Controller
    {
        // GET: Errors
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error400()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }
        public ActionResult Error500()
        {
            return View();
        }
        public ActionResult Error503()
        {
            return View();
        }
        public ActionResult AccessDenied()
        {
            return View();
        }
        public ActionResult Error401()
        {
            return View();
        }
    }
}