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
    public class RootObjectController : BaseController
    {
        GenericRepository<RootObject> productrepo = new GenericRepository<RootObject>();


        public ActionResult Index()
        {

            List<RootObjectVM> model = productrepo.GetAll().Select(q => new RootObjectVM()
            {
                id = q.id,
                Adi = q.name,
                Aciklama = q.description,
            }).ToList();

            return View(model);
        }

        [HttpGet]
        public ActionResult RootOjectEkle()
        {
            return View(GetFormVM());
        }

        [HttpPost]
        public ActionResult RootObjectEkle(FormVM model)
        {
            RootObject root = new RootObject();
            root.name = model.Ad;
            root.description = model.Aciklama;



            RootObjectManager.Add(root);

            return View(GetFormVM());

        }

        private FormVM GetFormVM()
        {
            List<RootObject> rootObject = RootObjectManager.GetAllRootObject();

            List<SelectListItem> items = new List<SelectListItem>();

            foreach (var item in rootObject)
            {
                SelectListItem selectitem = new SelectListItem();
                selectitem.Text = item.name;
                selectitem.Value = item.id.ToString();


                items.Add(selectitem);
            }


            FormVM model = new FormVM();
            model.Ad = "Test Form";
            model.Aciklama = "";

            return model;
        }

        public JsonResult Delete(int id)
        {
            RootObjectManager.Delete(id);
            return Json("");
        }
    }
}