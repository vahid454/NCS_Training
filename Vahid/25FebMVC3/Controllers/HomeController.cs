using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _25FebMVC3.Models;


namespace _25FebMVC3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public static EmployeeLayer employeeLayer = new EmployeeLayer();
        public static List<EmployeeModel> employees = employeeLayer.GetEmployeeDetails();
        bool user_active = false;
        public ActionResult Index()
        {
            if (user_active)
            {
                ViewBag.UserActive = true;
             
                ViewBag.EmployeeTitle = Session["username"];

            }
            else
            {
                ViewBag.UserActive = false;

            }
          
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.NotLogged = true;
            Session["logged"] = true;
            if (Session["logged"] != null)
            {
                ViewBag.NotLogged = false;
                Session["employee_title"] = "Vahid Kha Mansuri";
                ViewBag.EmployeeTitle = Session["employee_title"];
            }
            return View();
        }
        public ActionResult ContactUS()
        {
            ViewBag.NotLogged = true;
            Session["logged"] = true;
            if (Session["logged"] != null)
            {
                ViewBag.NotLogged = false;
                Session["employee_title"] = "Vahid Kha Mansuri";
                ViewBag.EmployeeTitle = Session["employee_title"];
            }
            return View();
        }
        public ActionResult AboutUS()
        {
            ViewBag.UserActive = true;
     
            if (Session["username"] != null)
            {
                ViewBag.NotLogged = false;
             
                ViewBag.EmployeeTitle = Session["username"];
            }
            return View();
        }



        [HttpGet]
        public ActionResult Login()
        {

            return View(new EmployeeModel());
        }


        [HttpPost]
        public ActionResult Login(EmployeeModel e)
        {
            ViewBag.UserActive = false;
            if (ModelState.IsValid)
            {

                if (e.Password.Equals("GREAT"))
                {
                    TempData["NewEmployee"] = e;
                    TempData.Keep("NewEmployee");
                    ViewBag.UserActive = true;
                    Session["username"] = e.Name;
                    return RedirectToAction("Index");


                }
                else 
                {
                    Response.Write("Employee Not Found!");
                    return View(e);
                }
                
            }
           
            return View(e);
        }


        [HttpGet]
        public ActionResult Registration()
        {

            return View(new EmployeeModel());
        }
        [HttpPost]
        public ActionResult Registration(EmployeeModel e)
        {
            ViewBag.UserActive = false;
            if (ModelState.IsValid)
            {
                if (e.Password.Equals(e.ConfirmPassword))
                {
                    return Redirect("Login");
                }
                else
                {
                    Response.Write("Password not matched!!");
                    return View(e);
                }
            }
            else 
            {
                Response.Write("Something wrong!!");
                return View(e);
            }

            return View(e);
        }

        public ActionResult AddEmployee()
        {
            return View();
        }
    }
}