using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nqn.Lesson03.Controllers
{
    /// <summary>
    /// Author: Nguyen Quang Nam
    /// Class: K22CNT2
    /// </summary>
    public class NqnController : Controller
    {
        // GET: Nqn
        public ActionResult Index()
        {
            // truyen du lieu tu controller -> view
            ViewBag.FullName = "Nguyen Quang Nam";
            ViewData["Birthday"] = "31/08/2004";
            TempData["Phone"] = "0707431804";
            return View();
        }
        public ActionResult Details()
        {
            string Nqnstr = "";
            Nqnstr += "<h3> Ho va ten: Nguyen Quang Nam </h3>";
            Nqnstr += "<p> Ma sp: 2210900048";
            Nqnstr += "<p> Dia chi mail: nam31804@gmail.com";
            ViewBag.Details = Nqnstr;

            return View("chitiet");
        }
        public ActionResult NgonNguRazor()
        {
            return View();
        }
        // html helper
        // get: nqn/addnew
        public ActionResult AddNewStudent()
        {
            return View();
        }
        public ActionResult AddNewStudent(FormCollection form) {
            // lay du lieu tren form
            string fullname = form["fullname"];
            string masv = form["MASV"];
            string taikhoan = form["taikhoan"];
            string matkhau = form["matkhau"];
            string Nqnstr = "<h3>" + fullname + "</h3>";
            Nqnstr += "<p>" + masv;
            Nqnstr += "<p>" + taikhoan;
            Nqnstr += "<p>" + matkhau;
            ViewBag.info = Nqnstr;
            return View("ketqua");
                
        }
    }
}