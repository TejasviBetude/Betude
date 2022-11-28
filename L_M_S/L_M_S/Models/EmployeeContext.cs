using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace L_M_S.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("myconnection")
            {
            }
        public DbSet<Employee> employees { get; set; }

    }

}