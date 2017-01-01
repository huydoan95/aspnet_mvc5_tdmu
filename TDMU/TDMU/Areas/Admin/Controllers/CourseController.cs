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
    public class CourseController : BaseController
    {
        // GET: Admin/Course
        public ActionResult Index()
        {
            var model = new CourseDao().ListAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var cat = new CourseDao().GetByID(id);
            SetViewBag(cat.Cat_ID);
            return View(cat);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Course cat)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                cat.Date = DateTime.Now;
                cat.CreateBy = session.UserName;
                cat.Url = CastString.Cast(cat.Name);
                var dao = new CourseDao();
                long id = dao.Insert(cat);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Course");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm khóa học không thành công!");
                }
            }
            SetViewBag();
            return View("Index");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Course cat)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                cat.Date = DateTime.Now;
                cat.CreateBy = session.UserName;
                cat.Url = CastString.Cast(cat.Name);
                var dao = new CourseDao();
                var result = dao.Update(cat);
                if (result)
                {
                    return RedirectToAction("Index", "Course");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật khóa học không thành công");
                }
            }
            return View("Index");

        }

        [HttpDelete]
        public ActionResult Delete(long id)
        {
            new CourseDao().Delete(id);
            return RedirectToAction("Index");
        }

        public void SetViewBag(long? selectedID = null)
        {
            var dao = new CategoryCourseDao();
            ViewBag.Cat_ID = new SelectList(dao.GetList(), "ID", "Name", selectedID);
        }
    }
}