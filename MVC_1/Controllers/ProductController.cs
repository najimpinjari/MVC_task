using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    [RoutePrefix("Product")]
    public class ProductController : Controller
    {
       // //http://localhost/product  // for attribute routig     

        [Route("")]
        public string GetProduct()
        {
            return "All list of Product";   
        }
      
    }
}