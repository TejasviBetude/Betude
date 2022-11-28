using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreNetDemo.Controllers;
using CoreNetDemo.Models;

namespace CoreNetDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

    }
}