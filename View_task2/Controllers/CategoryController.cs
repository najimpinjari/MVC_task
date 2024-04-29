using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_task2.Models;

namespace View_task2.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {

            //to show list of category 
            //inisialy we can show list using database 

            List<Category> categories = new List<Category>()
            {
                new Category(){ Id = 1, Name = "Shirt", Rating = 5 },
                new Category(){ Id = 2, Name = "Shoes", Rating = 3 },
                new Category(){ Id = 3, Name = "Jeans", Rating = 4 }
            };

            return View(categories);


        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult Create( string Name, string Rating )
        //public ActionResult Create (Category category)
        public ActionResult Create( FormCollection form)
        {
            string name = form["Name"];
            string rating = form["Rating"];

            return View();
        }


        [HttpPost]
        public ActionResult GetValue(string catname)
        {
            return RedirectToAction("Create");
        }
        public PartialViewResult GetPartialView()
        {
            return PartialView("_partialView" , 2000);   
        }
    }
}