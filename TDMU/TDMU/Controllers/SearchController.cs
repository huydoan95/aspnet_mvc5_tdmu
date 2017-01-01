using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;

namespace TDMU.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        [HttpGet]
        [CompressContent]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [CompressContent]
        public ActionResult Index(string key)
        {
            var model = new NewsDao().GetByKey(key);
            return View(model);
        }

        [OutputCache(Duration = int.MaxValue, Location = System.Web.UI.OutputCacheLocation.Client, VaryByParam = "url")]
        [CompressContent]
        public ActionResult Detail(string url)
        {
            var model = new NewsDao().GetByUrl(url);
            return View(model);
        }
    }
}