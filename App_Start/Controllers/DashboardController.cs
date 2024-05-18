using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookies.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["Username"]; // add cookiie class for request get 
            if (cookie != null) // the conditon if user is invlid or not 
            {
                ViewBag.message = Request.Cookies["Username"].Value.ToString();
            }
            else // and the else part as on...
            {
                return RedirectToAction("Login" , "Home"); // redirect to action controller or view     k
            }
            return View();
        }
    }
}