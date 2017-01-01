using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;

namespace TDMU.Areas.Admin.Controllers
{
    public class SlideController : BaseController
    {
        // GET: Admin/Slide
        public ActionResult Index()
        {
            var model = new SlideDao().ListAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var cat = new SlideDao().GetByID(id);
            return View(cat);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Slide cat)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                cat.Date = DateTime.Now;
                cat.CreateBy = session.UserName;
                cat.Url = CastString.Cast(cat.Name);
                var dao = new SlideDao();
                long id = dao.Insert(cat);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Slide");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm slide không thành công!");
                }
            }
            return View("Index");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Slide cat)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                cat.Date = DateTime.Now;
                cat.CreateBy = session.UserName;
                cat.Url = CastString.Cast(cat.Name);
                var dao = new SlideDao();
                var result = dao.Update(cat);
                if (result)
                {
                    return RedirectToAction("Index", "Slide");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật slide không thành công");
                }
            }
            return View("Index");

        }

        [HttpDelete]
        public ActionResult Delete(long id)
        {
            new SlideDao().Delete(id);
            return RedirectToAction("Index");
        }
    }
}