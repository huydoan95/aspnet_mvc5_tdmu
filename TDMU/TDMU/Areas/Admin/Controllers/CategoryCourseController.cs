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
    public class CategoryCourseController : BaseController
    {
        // GET: Admin/CategoryCourse
        public ActionResult Index()
        {
            var model = new CategoryCourseDao().GetList();
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
            var cat = new CategoryCourseDao().GetByID(id);
            return View(cat);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(CategoryCourse cat)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                cat.Date = DateTime.Now;
                cat.CreateBy = session.UserName;
                var dao = new CategoryCourseDao();
                long id = dao.Insert(cat);
                if (id > 0)
                {
                    return RedirectToAction("Index", "CategoryCourse");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm loại tin tức không thành công!");
                }
            }
            return View("Index");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(CategoryCourse cat)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                cat.Date = DateTime.Now;
                cat.CreateBy = session.UserName;
                var dao = new CategoryCourseDao();
                var result = dao.Update(cat);
                if (result)
                {
                    return RedirectToAction("Index", "CategoryCourse");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật loại khóa học không thành công");
                }
            }
            return View("Index");

        }

        [HttpDelete]
        public ActionResult Delete(long id)
        {
            new CategoryCourseDao().Delete(id);
            return RedirectToAction("Index");
        }
    }
}