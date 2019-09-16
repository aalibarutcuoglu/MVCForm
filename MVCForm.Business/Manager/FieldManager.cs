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
    public class FieldManager
    {

        public static void Update(Field field)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                db.Entry(field).State = EntityState.Modified;
                db.SaveChanges();
            }

        }

        public static void Delete(int id)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                Field field = db.Fields.FirstOrDefault(q => q.id == id);
                field.IsDeleted = true;
                field.DeleteDate = DateTime.Now;

                db.SaveChanges();

            }
        }

        public static void Add(Field field)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                field.AddDate = DateTime.Now;
                field.IsDeleted = false;
                field.UpdateDate = DateTime.Now;

                db.Fields.Add(field);

                db.SaveChanges();


            }
        }
    }
}
