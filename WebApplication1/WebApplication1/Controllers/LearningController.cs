using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LearningController : Controller
    {
        // GET: Learning
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Razer01()
        {
            return View();
        }
        public ActionResult Razer02()
        {
            return View();
        }
        public ActionResult LoadImage()
        {
            ViewBag.Item = 10;
            return View();
        }
    }
}