using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CategoryNewsDao
    {
        TDMUDbContext db = null;
        public CategoryNewsDao()
        {
            db = new TDMUDbContext();
        }

        public List<CategoryNew> GetList()
        {
            return db.CategoryNews.ToList();
        }

        public CategoryNew GetByID(long id)
        {
            return db.CategoryNews.Find(id);
        }

        public long Insert(CategoryNew entity)
        {
            db.CategoryNews.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(CategoryNew entity)
        {
            try
            {
                var cat = db.CategoryNews.Find(entity.ID);
                cat.Name = entity.Name;
                cat.Date = entity.Date;
                cat.CreateBy = entity.CreateBy;
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
                var cat = db.CategoryNews.Find(id);
                db.CategoryNews.Remove(cat);
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
