using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class RoleDao
    {
        TDMUDbContext db = null;
        public RoleDao()
        {
            db = new TDMUDbContext();
        }

        public List<Role> GetList()
        {
            return db.Roles.ToList();
        }

        public Role GetByID(long id)
        {
            return db.Roles.Find(id);
        }

        public bool Insert(Role entity)
        {
            db.Roles.Add(entity);
            db.SaveChanges();
            return true;
        }

        public bool Update(Role entity)
        {
            try
            {
                var news = db.Roles.Find(entity.ID);
                news = entity;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(long id)
        {
            try
            {
                var news = db.Roles.Find(id);
                db.Roles.Remove(news);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
