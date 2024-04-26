using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Data_task.Models;

namespace View_Data_task.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            ViewData["Message"] = "Message from View Data !! ";
            ViewData["Currnettime"] = DateTime.Now.ToLongTimeString();

            string[] friends = { "rupesh", "arbaj", "nilesh", "gotya" };
            ViewData["myfriends"] = friends;

            ViewData["sportlist"] = new List<string>
            {
                 "cricket",
                "football",
                "hockey",
                "volleyball"
            };

            Employee arbaj = new Employee();
            arbaj.Empid = 11;
            arbaj.EmpName = "Arbaj";
            arbaj.EmpDesigrantion = "JrEnginner";

            ViewData["Employee"] = arbaj;
               
               

            return View();
        }
    }
}