using CRUD_dbfa.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_dbfa.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        DB_MVC_forCRUDEntities1 dbobj = new DB_MVC_forCRUDEntities1();
        public ActionResult Employee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(tbl_Employee model)
        {
            if (ModelState.IsValid)
            {
                tbl_Employee obj = new tbl_Employee();
                obj.Name = model.Name;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Address = model.Address;

                dbobj.tbl_Employee.Add(obj);
                dbobj.SaveChanges();
            }

            ModelState.Clear();
            return View("Employee");
        }

        public ActionResult EmployeeList()
        {
            var data = dbobj.tbl_Employee.ToList();
            return View(data);
        }

        public ActionResult EditEmployee( tbl_Employee model )
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult EditEmployee_Post(tbl_Employee model)
        {

            if(ModelState.IsValid)
            {
                dbobj.Entry(model).State = System.Data.Entity.EntityState.Modified;
                dbobj.SaveChanges();
            }

            var data = dbobj.tbl_Employee.ToList();

            return View("EmployeeList" , data);
        }


        public ActionResult Delete(int id) 
        {
            var data = dbobj.tbl_Employee.Where(x => x.Id == id).First();
            dbobj.tbl_Employee.Remove(data);
            dbobj.SaveChanges();
                

            var emplist = dbobj.tbl_Employee.ToList();

            return View("EmployeeList", emplist);
        }
    }
}