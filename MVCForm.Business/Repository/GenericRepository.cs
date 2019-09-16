using MVCFrom.DAL.ORM.Context;
using MVCFrom.DAL.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForm.Business.Repository
{
    public class GenericRepository<TEntity> where TEntity : Base
    {
        MVCFormContext db;
        DbSet<TEntity> dbSet;

        public GenericRepository()
        {
            db = new MVCFormContext();
            this.dbSet = db.Set<TEntity>();
        }


        public void Add(TEntity entity)
        {
            entity.IsDeleted = false;
            entity.AddDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;

            dbSet.Add(entity);
            db.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return dbSet.Where(q => q.IsDeleted == false).ToList();
        }

        public void Delete(int id)
        {
            var entity = dbSet.FirstOrDefault(q => q.id == id);
            entity.IsDeleted = true;
            entity.DeleteDate = DateTime.Now;

            db.SaveChanges();

        }

        public void Update(TEntity entity)
        {
            using (MVCFormContext db = new MVCFormContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}
