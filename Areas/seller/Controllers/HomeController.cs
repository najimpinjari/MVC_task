using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area_newone.Areas.seller.Controllers
{
    [RouteArea("seller")]
    public class HomeController : Controller
    {
        // GET: seller/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}