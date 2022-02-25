using _23FebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23FebMVC.Controllers
{
    public class EmployeeController : Controller
    {

        public static EmployeeLayer employeeLayer = new EmployeeLayer();
        public static List<EmployeeModel> employees = employeeLayer.GetEmployeeDetails();
        // GET: Employee
        public ActionResult Index()
        {
                    
            return View();
        }
        public ActionResult DisplayAll()
        {
            if (TempData["NewEmployee"] != null)
            {
                EmployeeModel t = new EmployeeModel();
                EmployeeModel modelData = TempData["NewEmployee"] as EmployeeModel;
                t = modelData;
                if (t.City.Equals("Mumbai"))
                {
                    employees.Add(t);
                }
                else 
                {
                    Response.Write("Only Mumbaikars are allowed");
                    return View("CityNotMumbai");
                }
               // employees.Add(t);
            }
            else 
            {
                TempData["NewEmployee"] = null;
            }
            return View(employees);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            
            return View(new EmployeeModel());
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel e)
        {
            if (ModelState.IsValid)
            {

                TempData["NewEmployee"] = e;
                TempData.Keep("NewEmployee");
                return RedirectToAction("DisplayAll");
            }
            return View(e);

        }


        public ActionResult CityNotMumbai()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DeleteEmployee()
        {

            return View(new EmployeeModel());
        }
        [HttpPost]
        public ActionResult DeleteEmployee(EmployeeModel e)
          {
            Console.WriteLine(e.Id);
           
            if (ModelState.IsValid)
            {
                var flag = 0;
                foreach (var employee in employees)
                {
                    if (e.Id == employee.Id)
                    {
                        employees.Remove(employee);
                        flag = 1;
                    }

                }
                if (flag == 1)
                {
                    Response.Write("Employee Deleted");
                    return RedirectToAction("DisplayAll");

                }
                else
                {
                    Response.Write("Employee Not Found!");
                }


            }
            return View();



        }

        public ActionResult TempForm()
        {
            return View();
        }
       
    }
}