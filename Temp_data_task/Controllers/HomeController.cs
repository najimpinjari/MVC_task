using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Temp_data_task.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Var1"] = "message from view data";
            ViewBag.Var2 = "message from view bag";
            TempData["Var3"] = "message from temp data";

            //string[] friends = { "arbaj", "rupesh", "shifa", "nilesh" };

            //TempData["Friends"] = friends;

            //return View();

            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            if (TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }
            TempData.Keep();
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}