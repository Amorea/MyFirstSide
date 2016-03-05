using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstSide.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Like()
        {
            return View();
        }
        public ActionResult Want()
        {
            return View();
        }
    }
}