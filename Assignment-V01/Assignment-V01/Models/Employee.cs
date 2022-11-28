using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment_V01;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_V01.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Display(Name="Name Of employee")]
        [Required(ErrorMessage ="Enter the Name")]

        public string Name { get; set; }
        [Range(17,70,ErrorMessage ="Age must be Above 17 and below 70")]
        public int Age { get; set; }
        public string Gender { get; set; }
        [StringLength(15)]      
        public string Location { get; set; }

        public int Salary { get; set; }


    }
}