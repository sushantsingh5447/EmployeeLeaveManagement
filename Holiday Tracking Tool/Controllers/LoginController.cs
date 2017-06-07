using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Holiday_Tracking_Tool.Models;

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
        [HttpPost]
        public ActionResult Validation(Login loginModel)
        {
            if (ModelState.IsValid)
            {
                //TODO: SubscribeUser(model.Email);
            }
            return View("");
           // return View("Index", model);
        }
    }
}