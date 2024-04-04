using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {   // action method any method inside in controler is called action method 

        public string Welcome() //action method 
        {
            return "My First MVC Project";
        }

        public string GetResult( int id  )
        {
            return $"You Have pass {id}  input values ";
        }
        public string GetEmployeeData( int id , string name ) 
        {
            return $"Emplouyee  id {id} : Employee Name {name} ";
        }

        [Route("vhash/home/{id}/{studentname}")]
        public string GetStudentData(int id, string studentname)
        {
            return $"Student id {id} : Employee Name {studentname} ";
        }
    }
}