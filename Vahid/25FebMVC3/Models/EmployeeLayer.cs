using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _25FebMVC3.Models
{
    public class EmployeeLayer
    {
        public List<EmployeeModel> GetEmployeeDetails()
        {
            //Here we hardcoded the data  
            //usually we retrieve data from the database  
            List<EmployeeModel> employees = new List<EmployeeModel>();
            employees.Add(new EmployeeModel
            {
                Id = 101,
                Name = "Vahid",
                Email = "vahidmansuri@gmail.com",
                Password = "abc123",
                Age = 29,
                City = "Mumbai"
            });
          



            return employees;
        }


    }
}