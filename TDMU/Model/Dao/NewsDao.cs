using Model.EF;
using Model.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class NewsDao
    {
        TDMUDbContext db = null;
        public NewsDao()
        {
            db = new TDMUDbContext();
        }

        public News GetByUrl(string url)
        {
            return db.News.SingleOrDefault(x => x.Url == url);
        }

        public List<NewsViews> ListAll()
        {
            var model = from a in db.News
                        join b in db.CategoryNews
                        on a.Cat_ID equals b.ID
                        select new NewsViews()
                        {
                            ID = a.ID,
                            Name = a.Name,
                            CatName = b.Name,
                            Date = a.Date
                        };
            return model.ToList();
        }

        public List<News> GetByKey(string key)
        {
            return db.News.Where(x => x.Name.Contains(key)).ToList();
        }
        public List<News> GetListByCat(long cat,int num)
        {
            return db.News.Where(x=>x.Cat_ID == cat).OrderByDescending(x => x.ID).Take(num).ToList();
        }

        public News GetByID(long id)
        {
            return db.News.Find(id);
        }

        public List<News> GetSlideNews()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 1 && x.Slide == true).ToList();
        }

        public List<News> GetListNews(int num)
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 1 && x.Slide != true).Take(num).ToList();
        }

        public List<News> ListAllNews()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 1).ToList();
        }

        public List<News> ListAllAnnou()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 5).ToList();
        }

        public List<News> ListAllEvent()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 6).ToList();
        }

        public List<News> UpEvent()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 10014).ToList();
        }

        public List<News> ListAllAdmission()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 10011).ToList();
        }
        public List<News> ListAllCalendar()
        {
            long id = db.News.Where(x => x.Cat_ID == 7).Max(x => x.ID);
            News news = db.News.SingleOrDefault(x => x.ID == id);
            DateTime today = news.Date.Value;
            DateTime answer = today.AddDays(-21);
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 7).Where(x => x.Date >= answer || x.Date <= today).ToList();
        }
        public List<News> GetListCalendar(int num)
        {
            long id = db.News.Where(x => x.Cat_ID == 7).Max(x => x.ID);
            News news = db.News.SingleOrDefault(x => x.ID == id);
            //DateTime today = DateTime.Now;
            DateTime today = news.Date.Value;
            DateTime answer = today.AddDays(-21);
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 7).Where(x => x.Date >= answer || x.Date <= today).Take(num).ToList();
        }
        public List<News> ListAllCdio()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 10009).ToList();
        }

        public List<News> ListAllDepartment()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 10010).ToList();
        }

        public List<News> ListAllStudent()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 3).ToList();
        }

        public List<News> ListAllStaff()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 4).ToList();
        }

        public List<News> ListAllWork()
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 8).ToList();
        }

        public List<News> GetListWork(int num)
        {
            return db.News.OrderByDescending(x => x.ID).Where(x => x.Cat_ID == 8).Take(num).ToList();
        }
        public List<News> GetLastBlogs(int num)
        {
            return db.News.OrderByDescending(x => x.ID).Where(y => y.Cat_ID == 9).Take(num).ToList();
        }
        public List<News> ListAllBlogs()
        {
            return db.News.OrderByDescending(x => x.ID).Where(y => y.Cat_ID == 9).ToList();
        }
        public News GetFirstEvent()
        {
            var id =  db.News.OrderByDescending(x=>x.ID).Where(y => y.Cat_ID == 6).Max(x=>x.ID);
            return db.News.SingleOrDefault(x=>x.ID == id);
        }

        public News GetFirstUpEvent()
        {
            var id = db.News.OrderByDescending(x => x.ID).Where(y => y.Cat_ID == 10014).Max(x => x.ID);
            return db.News.SingleOrDefault(x => x.ID == id);
        }
        public List<News> GetUpEvent(int num)
        {
            long id = db.News.OrderByDescending(x => x.ID).Where(y => y.Cat_ID == 10014).Max(x => x.ID);
            return db.News.OrderByDescending(x => x.ID).Where(y => y.Cat_ID == 10014 && y.ID != id).Take(num).ToList();
        }
       public List<News> GetEvent(int num)
        {
            long id = db.News.OrderByDescending(x => x.ID).Where(y => y.Cat_ID == 6).Max(x => x.ID);
            return db.News.OrderByDescending(x => x.ID).Where(y => y.Cat_ID == 6 && y.ID != id).Take(num).ToList();
        }

        public long Insert(News entity)
        {
            db.News.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(News entity)
        {
            try
            {
                var news = db.News.Find(entity.ID);
                news.Name = entity.Name;
                news.Cat_ID = entity.Cat_ID;
                news.CreateBy = entity.CreateBy;
               // news.Date = entity.Date;
                news.Description = entity.Description;
                news.Description_google = entity.Description_google;
                news.Detail = entity.Detail;
                news.Title = entity.Title;
                news.Url = entity.Url;
                news.Keyword = entity.Keyword;
                news.Image = entity.Image;
                news.Slide = entity.Slide;
                news.Status = entity.Status;
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
                var news = db.News.Find(id);
                db.News.Remove(news);
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
