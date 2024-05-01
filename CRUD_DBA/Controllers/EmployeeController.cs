    using CRUD_DBA.DbContext;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    namespace CRUD_DBA.Controllers
    {
        public class EmployeeController : Controller
        {
            Db_Crud_dbfEntities dbobj = new  Db_Crud_dbfEntities();
            // GET: Employee
            public ActionResult Employee()
            {
                return View();
            }

        [HttpPost]
        public ActionResult AddEmployee(tbl_Employee model)
        {
            // Create a new tbl_Employe object
            tbl_Employee obj = new tbl_Employee();

            // Copy values from the model object
            obj.Name  = model.Name;
            obj.Email = model.Email;
            obj.Mobile = model.Mobile;
            obj.Address = model.Address;

            // Add the new object to the DbContext
            dbobj.tbl_Employee.Add(obj);

            // Save changes to the database
            dbobj.SaveChanges();

            // Redirect to the Employee view
            return RedirectToAction("Employee");
        }

    }
}