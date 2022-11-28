using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LeaveManagement_codef.Models;

namespace LeaveManagement_codef.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeID { get; set; }


        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-za-z]+))$")]

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and ConfirmPassword does not match")]
        public string ConfirmPassword { get; set; }

    }
}
