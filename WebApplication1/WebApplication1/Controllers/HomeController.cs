using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Personnel> personnels = new List<Personnel>();
            personnels.Add(new Personnel() { Name = "ali", PersonnelCode = 1 });
            personnels.Add(new Personnel() { Name = "mahdi", PersonnelCode = 2 });
            ViewData["msg"] = "This is a test";
            ViewBag.message2 = "this is a data from viewbag";
            ViewBag.Data = personnels;
            return View(personnels);
        }

        public ActionResult FirstLayoutSample()
        {
            return View();
        }

        public ActionResult TestLayout()
        {
            return View();
        }
    }
}