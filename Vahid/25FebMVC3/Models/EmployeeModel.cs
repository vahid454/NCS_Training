using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace _25FebMVC3.Models
{

    public class EmployeeModel
    {
        [Required(ErrorMessage = "ID is Required")]
        [Range(1, 1000, ErrorMessage = "Invalid ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter Valid Email ID")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }
       
        [Required(ErrorMessage = "Password Required")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(18, 100, ErrorMessage = "You are not eligible")]
        public int Age { get; set; }


        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Phone is Required")]
        [Range(6000000000, 9999999999, ErrorMessage = "Invalid Phone")]
        public int Phone { get; set; }

    }
}
/*
 [Required(ErrorMessage = "Email should be Required")]
[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter Valid Email ID")]
*/