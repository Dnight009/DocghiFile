using DocghiFile.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace DocghiFile.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Send(Email model)
        {

            var mail = new SmtpClient("SmtpClient.gmail.com", 25)
            {
                Credentials = new NetworkCredential("123@gmail.com", "Email"),
                EnableSsl = true
            };

            var m = new MailMessage();
            m.From = new MailAddress(model.From);
            m.ReplyToList.Add(model.From);
            m.To.Add(new MailAddress(model.To));
            m.Subject = model.Subject;
            m.Body = model.Body;

            mail.Send(m);


            return View();
        }
    }
}
            


  
