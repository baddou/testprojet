using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "baddou";
            emp.LastName = "mustapha";
            emp.Salary = 10000;
            ViewBag.emp = emp;
            return View("MyView");
        }
    }
}