using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo01.Models;

namespace WebAPIDemo01.Repository
{
    interface IDepartmentRepo
    {
        public IEnumerable<Department> GetAllDepartments();
        public Department GetDepartmentById(int id);
        public IEnumerable<Department> GetDepartmentByLocation(string location);
        public string AddNewDepartment(Department department);
        public string UpdateDepartmentDetails(Department department);
        public string DeleteDepartment(int id);

    }
}
