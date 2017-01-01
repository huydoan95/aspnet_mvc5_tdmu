using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDMU.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items

        public ActionResult Index()
        {
            return View();
        }
    }
}