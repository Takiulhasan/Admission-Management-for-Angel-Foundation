using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelBd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult Admission()
        {
            ViewBag.message = "Fill up the admission form.";

            //if (User.Identity.IsAuthenticated)
            //{
                
            //}
                return RedirectToAction("Create", "Admissions");
        }
        public ActionResult Gallery()
        {
            ViewBag.message = "GALLARY";

            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.message = "BLOG";

            return View();
        }

        public ActionResult Student()
        {
            return RedirectToAction("Index", "Admissions");
        }
        public ActionResult Donate()
        {
            return View();
        }
    }
}