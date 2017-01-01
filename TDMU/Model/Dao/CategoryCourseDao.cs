using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CategoryCourseDao
    {
        TDMUDbContext db = null;
        public CategoryCourseDao()
        {
            db = new TDMUDbContext();
        }

        public List<CategoryCourse> GetList()
        {
            return db.CategoryCourses.ToList();
        }

        public CategoryCourse GetByID(long id)
        {
            return db.CategoryCourses.Find(id);
        }

        public long Insert(CategoryCourse entity)
        {
            db.CategoryCourses.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(CategoryCourse entity)
        {
            try
            {
                var course = db.CategoryCourses.Find(entity.ID);
                course.Name = entity.Name;
                course.Date = entity.Date;
                course.CreateBy = entity.CreateBy;
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
                var course = db.CategoryCourses.Find(id);
                db.CategoryCourses.Remove(course);
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
