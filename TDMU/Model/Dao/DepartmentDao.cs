using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class DepartmentDao
    {
        TDMUDbContext db = null;
        public DepartmentDao()
        {
            db = new TDMUDbContext();
        }

        public List<Department> GetList()
        {
            return db.Departments.ToList();
        }

        public bool Insert(Department entity)
        {
            db.Departments.Add(entity);
            db.SaveChanges();
            return true;
        }

        public bool Update(Department entity)
        {
            try
            {
                var course = db.Departments.Find(entity.ID);
                course.Name = entity.Name;
                course.Cat_ID = entity.Cat_ID;
                course.CreateBy = entity.CreateBy;
                course.Date = entity.Date;
                course.Description = entity.Description;
                course.Description_google = entity.Description_google;
                course.Detail = entity.Detail;
                course.Title = entity.Title;
                course.Url = entity.Url;
                course.Keyword = entity.Keyword;
                course.Image = entity.Image;
                course.Status = entity.Status;
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
                var course = db.Departments.Find(id);
                db.Departments.Remove(course);
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
