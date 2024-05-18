using Cookies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if(ModelState.IsValid == true   )
            {
                HttpCookie cookie = new HttpCookie("Username");
                cookie.Value = user.UserName;
                HttpContext.Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Dashboard");   
            }
            return View();
        }

    }
}