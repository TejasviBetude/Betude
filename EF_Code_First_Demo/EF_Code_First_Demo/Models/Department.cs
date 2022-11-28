using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF_Code_First_Demo.Models;

namespace EF_Code_First_Demo.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
       
        public string Name { get; set; }
        public string Location { get; set; }
       // public string DepartmentHead { get; set; }
    }
}