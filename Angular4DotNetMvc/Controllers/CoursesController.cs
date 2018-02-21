using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View("Index", "", "you");
        }
    }
}