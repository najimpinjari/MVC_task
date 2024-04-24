using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area_newone.Areas.admin.Controllers
{
    [RouteArea("admin")]
    public class HomrtController : Controller
    {
        // GET: admin/Homrt
        public ActionResult Index()
        {
            return View();
        }
    }
}