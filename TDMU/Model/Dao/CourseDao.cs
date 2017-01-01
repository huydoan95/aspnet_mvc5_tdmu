using Model.EF;
using Model.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CourseDao
    {
        TDMUDbContext db = null;
        public CourseDao()
        {
            db = new TDMUDbContext();
        }

        public List<CourseView> ListAll()
        {
            var model = from a in db.Courses
                        join b in db.CategoryCourses
                        on a.Cat_ID equals b.ID
                        select new CourseView()
                        {
                            ID = a.ID,
                            Name = a.Name,
                            CatName = b.Name,
                            Date = a.Date
                        };
            return model.ToList();
        }

        public List<Course> ListAllIndex()
        {
            return db.Courses.ToList();
        }

        public Course GetByUrl(string url)
        {
            return db.Courses.SingleOrDefault(x => x.Url == url);
        }

        public Course GetByID(long id)
        {
            return db.Courses.Find(id);
        }

        public List<Course> GetList(int num)
        {
            return db.Courses.OrderByDescending(x => x.ID).Take(num).ToList();
        }

        public long Insert(Course entity)
        {
            db.Courses.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(Course entity)
        {
            try
            {
                var course = db.Courses.Find(entity.ID);
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
                var course = db.Courses.Find(id);
                db.Courses.Remove(course);
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
