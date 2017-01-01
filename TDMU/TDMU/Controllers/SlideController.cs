using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;

namespace TDMU.Controllers
{
    public class SlideController : Controller
    {
        // GET: Slide
        [CompressContent]
        public ActionResult Index()
        {
            var dao = new SlideDao();
            var model = dao.ListAll();
            return View(model);
        }

        [CompressContent]
        public ActionResult Detail(string url)
        {
            var model = new SlideDao().GetByUrl(url);
            return View(model);
        }
    }
}