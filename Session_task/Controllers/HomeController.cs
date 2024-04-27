using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session_task.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Var1"] = "data comes from viewdata";
            ViewBag.Var2 = "data comes from viewbag";
            TempData["Var3"] = "data comes from Tempdata";


            Session["Var4"] = "data comes from sesion ";
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}