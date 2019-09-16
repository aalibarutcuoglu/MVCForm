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
   public class AdminUserManager
    {
        public static List<AdminUser> GetAllAdminUsers()
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                return db.AdminUsers.ToList();
            }
        }

        public static void AddAdminUser(AdminUser adminuser)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                adminuser.InsertedUserID = 1;
                adminuser.UpdatedUserID = 1;
                adminuser.AddDate = DateTime.Now;
                adminuser.IsDeleted = false;
                adminuser.UpdateDate = DateTime.Now;

                db.AdminUsers.Add(adminuser);

                db.SaveChanges();

            }
        }


        public static void Update(AdminUser adminuser)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                db.Entry(adminuser).State = EntityState.Modified;
                db.SaveChanges();
            }

        }

        public static void Delete(int id)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                AdminUser adminuser = db.AdminUsers.FirstOrDefault(q => q.id == id);
                adminuser.IsDeleted = true;
                adminuser.DeleteDate = DateTime.Now;

                db.SaveChanges();

            }
        }

       

    }
}
