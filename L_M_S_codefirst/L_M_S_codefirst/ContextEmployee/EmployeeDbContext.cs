using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace L_M_S_codefirst.ContextEmployee
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
