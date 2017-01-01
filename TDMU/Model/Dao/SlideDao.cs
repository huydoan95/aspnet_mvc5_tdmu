using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class SlideDao
    {
        TDMUDbContext db = null;
        public SlideDao()
        {
            db = new TDMUDbContext();
        }

        public List<Slide> ListAll()
        {
            return db.Slides.ToList();
        }

        public Slide GetByUrl(string url)
        {
            return db.Slides.SingleOrDefault(x => x.Url == url);
        }

        public List<Slide> ListSlide()
        {
            return db.Slides.OrderByDescending(x => x.ID).ToList();
        }

        public Slide GetByID(long id)
        {
            return db.Slides.Find(id);
        }

        public long Insert(Slide entity)
        {
            db.Slides.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(Slide entity)
        {
            try
            {
                var course = db.Slides.Find(entity.ID);
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
                course.ImageLoad = entity.ImageLoad;
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
                var slide = db.Slides.Find(id);
                db.Slides.Remove(slide);
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
