using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Saaf_City.Models;

namespace Saaf_City.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult index()
        {
            return View();
        }
        public ActionResult loginGarbage()
        {
            return View();
        }
        public ActionResult loginSewage()
        {
            return View();
        }

        public ActionResult log()
        {
            return View();
        }
        public ActionResult register()
        {
            return View();
        }
        public ActionResult resetPass()
        {
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }
        public ActionResult Employees()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();

        }
        public ActionResult done_comgarbage()
        {
            return View();
        }
        public ActionResult done_comsewage()
        {
            return View();
        }
        public ActionResult homepage_Garbage()
        {
            return View();
        }
        public ActionResult homepage_Sewage()
        {
            return View();
        }
        public ActionResult in_prog_garbage()
        {
            return View();
        }
        public ActionResult in_prog_sewage()
        {
            return View();
        }
        public ActionResult Total_complaints_garbage()
        {
            return View();
        }
        public ActionResult Total_complaints_sewage()
        {
            return View();
        }
        public ActionResult unver_com_garbage()
        {
            return View();
        }
        public ActionResult unver_com_sewage()
        {
            return View();
        }
        public ActionResult ver_com_garbage()
        {
            return View();
        }
        public ActionResult var_com_sewage()
        {
            return View();
        }
    }
}