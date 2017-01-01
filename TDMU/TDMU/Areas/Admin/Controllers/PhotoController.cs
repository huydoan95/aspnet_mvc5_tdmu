using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDMU.Areas.Admin.Controllers
{
    public class PhotoController : BaseController
    {
        // GET: Admin/Photo
        public ActionResult Index()
        {
            var model = new PhotoDao().ListAllPhoto();
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
            var cat = new PhotoDao().GetByID(id);
            return View(cat);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Photo cat)
        {
            if (ModelState.IsValid)
            {
                var dao = new PhotoDao();
                long id = dao.Insert(cat);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Photo");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm photo không thành công!");
                }
            }
            return View("Index");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Photo cat)
        {
            if (ModelState.IsValid)
            {
                var dao = new PhotoDao();
                var result = dao.Update(cat);
                if (result)
                {
                    return RedirectToAction("Index", "Photo");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật photo không thành công");
                }
            }
            return View("Index");

        }

        [HttpDelete]
        public ActionResult Delete(long id)
        {
            new PhotoDao().Delete(id);
            return RedirectToAction("Index");
        }
    }
}