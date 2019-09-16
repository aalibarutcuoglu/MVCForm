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
    public class WebUserManager
    {

        public static List<WebUser> GetAllWebUsers()
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                return db.WebUsers.Where(q => q.IsDeleted == false).ToList();
            }
        }


        public static void Update(WebUser webUser)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                db.Entry(webUser).State = EntityState.Modified;
                db.SaveChanges();
            }

        }

        public static void Delete(int id)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                WebUser webuser = db.WebUsers.FirstOrDefault(q => q.id == id);
                webuser.IsDeleted = true;
                webuser.DeleteDate = DateTime.Now;

                db.SaveChanges();

            }
        }

        public static void Add(WebUser webuser)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                webuser.AddDate = DateTime.Now;
                webuser.IsDeleted = false;
                webuser.UpdateDate = DateTime.Now;

                db.WebUsers.Add(webuser);

                db.SaveChanges();


            }
        }
    }
}
