﻿using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;

namespace TDMU.Controllers
{
    public class AnnoucementController : Controller
    {
        // GET: Annoucement
        [CompressContent]
        public ActionResult Index()
        {
            var dao = new NewsDao();
            var model = dao.ListAllAnnou();
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