using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class UserDao
    {
        TDMUDbContext db = null;
        public UserDao()
        {
            db = new TDMUDbContext();
        }

        public List<User> ListAll()
        {
            return db.Users.ToList();
        }

        public User GetByID(long id)
        {
            return db.Users.Find(id);
        }

        public User GetByUser(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }

        public int Login(string userName, string passWord)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Status == false)
                {
                    return -1;
                }
                else
                {
                    if (result.PassWord == passWord)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
        }
        public List<User> GetList()
        {
            return db.Users.ToList();
        }

        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(User entity)
        {
            try
            {
                var news = db.Users.Find(entity.ID);
                news.Name = entity.Name;
                news.PassWord = entity.PassWord;
                news.Phone = entity.Phone;
                news.Address = entity.Address;
                news.Email = entity.Email;
                news.Role = entity.Role;
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
                var news = db.Users.Find(id);
                db.Users.Remove(news);
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
