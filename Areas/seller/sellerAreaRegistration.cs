﻿using System.Web.Mvc;

namespace Area_newone.Areas.seller
{
    public class sellerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "seller";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "seller_default",
                "seller/{controller}/{action}/{id}",
                new { controller = "Home",  action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}