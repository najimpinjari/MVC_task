using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area_for_mvc.Areas.Account.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Account
        public ActionResult Index()
        {
            if (!this.ControllerContext.RouteData.DataTokens.ContainsKey("area"))
            {
                this.ControllerContext.RouteData.DataTokens.Add("area", "AccountArea");
            }
            return View();
        }
    }
}