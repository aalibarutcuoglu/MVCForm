using MVCForm.Business.Repository;
using MVCFrom.DAL.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCForm.UI.Web.Controllers
{
   
        [Authorize]
        public class BaseController : Controller
        {

            public GenericRepository<RootObject> rprootobject;
            public GenericRepository<Field> rpfield;
            public GenericRepository<WebUser> rpwebuser;


            public BaseController()
            {
                rprootobject = new GenericRepository<RootObject>();
                rpfield = new GenericRepository<Field>();
                rpwebuser = new GenericRepository<WebUser>();

            }

            protected override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                ViewBag.UserName = HttpContext.User.Identity.Name;
            }

            protected override void OnActionExecuted(ActionExecutedContext filterContext)
            {

            }

        }
    }
