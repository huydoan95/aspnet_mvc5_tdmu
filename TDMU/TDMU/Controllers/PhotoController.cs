using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;

namespace TDMU.Controllers
{
    public class PhotoController : Controller
    {
        //
        // GET: /Photo/
        [CompressContent]
        public ActionResult Index()
        {
            var dao = new PhotoDao().ListAllPhoto();
            return View(dao);
        }

       
        public ActionResult SlidePhoto()
        {
            var dao = new PhotoDao();
            var model = dao.ListAll();
            return PartialView(model);
        }
	}
}