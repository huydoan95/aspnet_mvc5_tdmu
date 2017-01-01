using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;

namespace TDMU.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration = 600)]
        [CompressContent]
        public ActionResult Index()
        {
            var dao = new NewsDao();
            var model = dao.GetListCalendar(3);
            return View(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]        
        public ActionResult Slide()
        {
            var model = new SlideDao().ListSlide();
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]   
        public ActionResult Annoucement()
        {
            var model = new NewsDao().GetListByCat(5,6);
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]        
        public ActionResult Events()
        {
            var dao = new NewsDao();
            var model = dao.ListAllEvent();
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]       
        public ActionResult UpEvents()
        {
            var dao = new NewsDao();
            ViewBag.FirstUpEvent = dao.GetFirstUpEvent();
            var model = dao.GetUpEvent(4);
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]      
        public ActionResult LastNews()
        {
            var dao = new NewsDao();
            var model = dao.GetSlideNews();
            ViewBag.ListNews = dao.GetListNews(6);
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]        
        public ActionResult LastBlogs()
        {
            var dao = new NewsDao();
            var model = dao.GetLastBlogs(3);
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]       
        public ActionResult Event()
        {
            var dao = new NewsDao();
            ViewBag.FirstEvent = dao.GetFirstEvent();
            var model = dao.GetEvent(4);
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]        
        public ActionResult Photo()
        {
            var dao = new PhotoDao();
            var model = dao.ListAll();
            return PartialView(model);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 600)]        
        public ActionResult Work()
        {
            var dao = new NewsDao();
            var model = dao.GetListWork(3);
            return PartialView(model);
        }
    }
}