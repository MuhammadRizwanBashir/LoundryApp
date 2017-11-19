using Repository.Pattern;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class RolesController : BaseController
    {
        Result<int> saveResult = new Result<int>();
        private IRolesService _rolesService;
        private readonly IUnitOfWorkAsync _unitOfWork;
        public RolesController(IRolesService rolesService, IUnitOfWorkAsync unitOfWork)
        {
            _rolesService = rolesService;
            _unitOfWork = unitOfWork;
        }
        // GET: Roles
        public ActionResult Index(int? id)
        {
            RolesViewModels model = new RolesViewModels();
            model.RolesList = _rolesService.Queryable().data;
            if (id > 0)
            {
                model.Roles = _rolesService.Find(id).data;
            }
            else
            {
                model.Roles = new Roles();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RolesViewModels model)
        {
            model.Roles.ObjectState=model.Roles.RoleId > 0 ? ObjectState.Modified : ObjectState.Added;
            _rolesService.InsertOrUpdateGraph(model.Roles);
            saveResult = _unitOfWork.SaveChanges();
            if (saveResult.success)
            {
                RouteData.Values.Remove("id");
                return RedirectToAction("Index");
            }
            model.RolesList = _rolesService.Queryable().data;
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            _rolesService.Delete(id);
            saveResult = _unitOfWork.SaveChanges();
            if (saveResult.success)
            {
                TempData["SuccessMessage"] = "Deleted successfully.";
            }
            else
            {
                //AddErrors(saveResult.errors, saveResult.ErrorMessage);
            }
            RouteData.Values.Remove("id");
            return RedirectToAction("Index");
        }
    }
}