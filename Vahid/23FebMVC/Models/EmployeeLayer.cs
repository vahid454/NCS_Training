using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23FebMVC.Models
{
    public class EmployeeLayer
    {
        public List<EmployeeModel> GetEmployeeDetails()
        {
            //Here we hardcoded the data  
            //usually we retrieve data from the database  
            List<EmployeeModel> employees = new List<EmployeeModel>();
            employees.Add(new EmployeeModel{
                Id = 101,
                Name = "Zain Malik",
                Age = 29,
                City = "Mumbai"
            });
            employees.Add(new EmployeeModel
            {
                Id = 102,
                Name = "John Carter",
                Age = 23,
                City = "Mumbai"
            });
            employees.Add(new EmployeeModel
            {
                Id = 103,
                Name = "Kane William",
                Age = 35,
                City = "Jaipur"
            });
            employees.Add(new EmployeeModel
            {
                Id = 104,
                Name = "Dane Johnson",
                Age = 21,
                City = "Bangalore"
            });
            employees.Add(new EmployeeModel
            {
                Id = 105,
                Name = "Alex Wood",
                Age = 22,
                City = "Mumbai"
            });


            

            return employees;
        }


    }
}