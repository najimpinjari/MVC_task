using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_bag_task.Models;

namespace View_bag_task.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "i am a full stack developer ";
            ViewBag.Currentdate = DateTime.Now.ToLongDateString();

            string[] friends = { "arbaj", "nilesh", "rupesh", "gotya" };
            ViewBag.myfriends = friends;

            ViewBag.sportlist = new List<string>()
            {
                "cricket",
                    "hollyball",
                    "football",
                    "rummy"
            };

            Employee  employee = new Employee();

            employee.Empdesignation = "maneger";
            employee.EmpName = "rupesh";
            employee.EmpId = 1;

            ViewBag.Myemployee = employee;

            ViewBag.commonmessagee = "this message is accessible for both the types view bag and view data  ";



            return View();
        }
    }
}