using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilters.Controllers
{
    // [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        // [RequireHttps]
        // [HandleError]
        public ActionResult Index()
        {
            //try
            //{
            //    throw new Exception("My Custom Exception Intentionally Thrown");                
            //}
            //catch
            //{
            //    return View("About");
            //}

            throw new Exception("My Custom Exception Intentionally Thrown");
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PostComments(string comment)
        {
            ViewBag.Comment = comment;

            return View("PostComments");
        }

        // [OutputCache(Duration = 10)]
        [OutputCache(CacheProfile = "10SecsCache")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.LoadedTime = DateTime.Now;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly] // filter
        public PartialViewResult LoginSection()
        {
            return PartialView("_LoginPartial");
        }
    }
}