using MVCForm.Business.Manager;
using MVCForm.Business.Repository;
using MVCForm.UI.Web.Models.VM;
using MVCFrom.DAL.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCForm.UI.Web.Controllers
{
    public class AdminUserController : BaseController
    {
        public ActionResult Index()
        {
            List<AdminUser> adminusers = AdminUserManager.GetAllAdminUsers();

            return View(adminusers);
        }

        public ActionResult AddAdminUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdminUser(AdminUserVM model)
        {
            AdminUser entity = new AdminUser();
            entity.Username = model.Username.ToLower();
            entity.Password = model.Password;

            AdminUserManager.AddAdminUser(entity);
            return View();
        }
    }
}