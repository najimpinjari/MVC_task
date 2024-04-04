using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Action_method.Controllers
{
    public class Home_DefaultController : Controller //first get reqvest get  controlar
    {
        // GET: Home_Default
        public ActionResult Index() //view generate karte he action mathods
        {
            return View("View_index");
        }
    }
}