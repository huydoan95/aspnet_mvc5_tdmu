using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class PhotoDao
    {
        TDMUDbContext db = null;
        public PhotoDao()
        {
            db = new TDMUDbContext();
        }

        public List<Photo> ListAll()
        {
            return db.Photos.OrderByDescending(x=>x.ID).Take(12).ToList();
        }

        public List<Photo> ListAllPhoto()
        {
            return db.Photos.OrderByDescending(x => x.ID).ToList();
        }

        public Photo GetByID(long id)
        {
            return db.Photos.Find(id);
        }

        public long Insert(Photo entity)
        {
            db.Photos.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(Photo entity)
        {
            try
            {
                var photo = db.Photos.Find(entity.ID);
                photo.Name = entity.Name;
                photo.Image = entity.Image;
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
                var news = db.Photos.Find(id);
                db.Photos.Remove(news);
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
