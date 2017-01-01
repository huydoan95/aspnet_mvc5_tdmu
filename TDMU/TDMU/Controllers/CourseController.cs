using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;

namespace TDMU.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        [CompressContent]
        public ActionResult Index()
        {
            var dao = new CourseDao();
            var model = dao.ListAllIndex();
            return View(model);
        }
        [OutputCache(Duration = int.MaxValue, Location = System.Web.UI.OutputCacheLocation.Client, VaryByParam = "url")]
        [CompressContent]
        public ActionResult Detail(string url)
        {
            var model = new CourseDao().GetByUrl(url);
            return View(model);
        }
    }
}