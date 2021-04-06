using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelBd.Controllers
{
    public class PostManageController : Controller
    {
        // GET: PostManage
        public ActionResult AddNewPost()
        {
            return View();
        }
        public ActionResult DisplayPostForUser()  
        {
            return View();
        }
    }
}