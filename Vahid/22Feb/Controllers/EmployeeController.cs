using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22febMVC.Controllers
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    public class EmployeeController : Controller
    {
        // GET: Employee
     

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayAll()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            employees.Add(new EmployeeModel { Id = 101, Name = "Vijay", Age = 22, City = "Sarangpur" });
            employees.Add(new EmployeeModel { Id = 102, Name = "Vinod", Age = 24, City = "Ujjain" });
            employees.Add(new EmployeeModel { Id = 103, Name = "Vipin", Age = 20, City = "Pune" });
            employees.Add(new EmployeeModel { Id = 104, Name = "Vishesh", Age = 30, City = "Chennai" });

            ViewBag.Employees = employees;
            TempData["Employees"]=employees;
            return View();
        }
        public ActionResult Display2()
        {
            if (TempData["Employees"]!=null)
            {
                ViewBag.Employees = TempData["Employees"];
                return View();
            }
            else 
            {
                return RedirectToAction("Index");
            }
        }
    }
}
