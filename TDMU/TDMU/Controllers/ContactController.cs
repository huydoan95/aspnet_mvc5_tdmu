
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDMU.Common;
using TDMU.Models;

namespace TDMU.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact   
        [CompressContent]
        public ActionResult Index()
        {
            var model = new ContactModel();
            return View(model);
        }

        [HttpPost]
        [CompressContent]
        public ActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                string smtpUserName = "en.tdmu.edu.vn@gmail.com";
                string smtpPassword = "tdmu1234";
                string smtpHost = "smtp.gmail.com";
                int smtpPort = 587;

                string emailTo = "info@tdmu.edu.vn"; // Khi có liên hệ sẽ gửi về thư của mình
                string subject = model.Subject;
                string body = string.Format("<b>{0}</b><br/>You've received contact from : <b>{1}</b><br/>Email: {2}<br/>Phone: {3}<br/>Message: </br>{4}",
                   model.Subject, model.UserName, model.Email,model.Phone, model.Message);

                EmailService service = new EmailService();

                bool kq = service.Send(smtpUserName, smtpPassword, smtpHost, smtpPort,
                    emailTo, subject, body);

                //if (kq) ModelState.AddModelError("", "Thank you for contacting us.");
                //else ModelState.AddModelError("", "Send Message failed , please try again.");
                if (kq)
                {
                    return Redirect("/Success");
                }
                else
                {
                    ModelState.AddModelError("", "Send Message failed , please try again.");
                }
            }
            return View(model);
        }
        [CompressContent]
        public ActionResult Success()
        {
            return View();
        }
    }
}


