using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocghiFile.Controllers
{
    public class UpLoadFileController : Controller
    {
        // GET: UpLoadFile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            var image = Request.Files["image"];
            var document = Request.Files["document"];
            var path = Server.MapPath("~/UploadFile/");


            if (image!= null &&image.ContentLength >0)
            {
                image.SaveAs(path + image.FileName);
                ViewBag.FileNameImage=image.FileName;
            }

            if (document != null && document.ContentLength > 0)
            {
                document.SaveAs(path + document.FileName);
                ViewBag.FileName = document.FileName;
                ViewBag.FileSize = document.ContentLength;
                ViewBag.FileStyle = document.ContentType;
            }

            return View();
        }
    }
}