using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;

namespace TDMU.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        [CompressContent]
        public ActionResult Index()
        {
            return View();
        }
    }
}