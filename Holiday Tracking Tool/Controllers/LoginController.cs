using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holiday_Tracking_Tool.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Authentication()
        {
            // console.writeine
            return View("Authentication");
        }
    }
}