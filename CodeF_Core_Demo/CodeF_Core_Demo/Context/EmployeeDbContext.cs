using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeF_Core_Demo.Context
{
    public class EmployeeDbContext
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string CompanyName { get; set; }

        public string Designation { get; set; }

        public float Salary { get; set; }

    }
}
