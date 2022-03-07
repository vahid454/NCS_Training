using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _7MarchLearning.Models;

namespace _7MarchLearning.Controllers
{
    public class HomeController : Controller
    {
        private OrganizationDataModel db = new OrganizationDataModel();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult ListOfEmployees()
        {
         

            return View(db.employees);
        }
        [HttpGet]
        public ActionResult EmployeeCreateView()
        {


            return View();
        }
        [HttpPost]
        public ActionResult EmployeeCreateView(employee e)
        {
            if (ModelState.IsValid)
            {
                db.employees.Add(e);
                db.SaveChanges();
                return RedirectToAction("ListOfEmployees");
            }
            else 
            {
                return View();
            }
           
        }
    }
}
