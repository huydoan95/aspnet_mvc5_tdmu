using TDMU.Common;
using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDMU.Areas.Admin.Controllers
{
    public class NewsController : BaseController
    {
        // GET: Admin/News
        public ActionResult Index()
        {
            var model = new NewsDao().ListAll();
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
            var service = new NewsDao().GetByID(id);
            SetViewBag(service.Cat_ID);
            return View(service);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(News news)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                news.Date = DateTime.Now;
                news.CreateBy = session.UserName;
                news.Url = CastString.Cast(news.Name);
                var dao = new NewsDao();
                long id = dao.Insert(news);
                if (id > 0)
                {
                    return RedirectToAction("Index", "News");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm tin tức không thành công!");
                }
            }
            SetViewBag();
            return View("Index");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(News news)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstant.USER_SESSION];
                news.Date = DateTime.Now;
                news.CreateBy = session.UserName;
                news.Url = CastString.Cast(news.Name);
                var dao = new NewsDao();
                var result = dao.Update(news);
                if (result)
                {
                    return RedirectToAction("Index", "News");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật tin tức không thành công");
                }
            }
            return View("Index");

        }

        [HttpDelete]
        public ActionResult Delete(long id)
        {
            new NewsDao().Delete(id);
            return RedirectToAction("Index");
        }

        public void SetViewBag(long? selectedID = null)
        {
            var dao = new CategoryNewsDao();
            ViewBag.Cat_ID = new SelectList(dao.GetList(), "ID", "Name", selectedID);
        }
    }
}