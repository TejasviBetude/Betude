using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreNetDemo.Models;
using CoreNetDemo.Controllers;


namespace CoreNetDemo.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}
