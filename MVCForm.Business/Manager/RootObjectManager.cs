using MVCFrom.DAL.ORM.Context;
using MVCFrom.DAL.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForm.Business.Manager
{
    public class RootObjectManager
    {
        public static List<RootObject> GetAllRootObject()
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                return db.RootObjects.ToList();
            }
        }
        public static void Update(RootObject rootObject)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                db.Entry(rootObject).State = EntityState.Modified;
                db.SaveChanges();
            }

        }

        public static void Delete(int id)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                RootObject rootObject = db.RootObjects.FirstOrDefault(q => q.id == id);
                rootObject.IsDeleted = true;
                rootObject.DeleteDate = DateTime.Now;

                db.SaveChanges();

            }
        }

        public static void Add(RootObject rootObject)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                rootObject.AddDate = DateTime.Now;
                rootObject.IsDeleted = false;
                rootObject.UpdateDate = DateTime.Now;

                db.RootObjects.Add(rootObject);

                db.SaveChanges();


            }
        }
    }
}
