using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;

namespace DocghiFile.Controllers
{
    public class DocGhiFileController : Controller
    {
        // GET: DocGhiFile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(string MaSV, string HoTenSV, Double DiemSO)
        {
            try
            {
                var path = Server.MapPath("~/Data.txt");
                 string[] lines = { MaSV, HoTenSV,DiemSO.ToString()};
                System.IO.File.WriteAllLines(path, lines);
                ViewBag.KetQua = "Ghi Thanh Cong";
            }
            catch (Exception ex)
            {
                ViewBag.KetQua = "Ghi That Bai";
            }
            

            return View("Index");
        }

        public ActionResult Open()
        {
            try
            {
                var path = Server.MapPath("~/Data.txt");
                string[] lines= System.IO.File.ReadAllLines(path);
                ViewBag.MaSV = lines[0];
                ViewBag.HoTenSv = lines[1];
                ViewBag.DiemSo = lines[2];
                ViewBag.KetQua = "doc thanh cong";
            }
            catch
            {
                ViewBag.KetQua = "Ghi That Bai";
            }
            return View("Index");
        }

    }
}