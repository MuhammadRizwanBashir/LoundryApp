using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Identity;

namespace WebApp.Controllers
{
    [CustomAuthorize]
    public class BaseController : Controller
    {
        public void AddErrors(List<string> errors, string message)
        {
            if (errors == null || errors.Count == 0)
            {
                ModelState.AddModelError("", message);
            }
            else
            {
                foreach (string s in errors)
                {
                    ModelState.AddModelError("", s);
                }
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}