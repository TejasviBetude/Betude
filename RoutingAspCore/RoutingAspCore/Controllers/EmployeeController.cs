using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoutingAspCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("Emp/All")]
        public string GetAllEmployees()
        {
            return "Response From GetAllEmployees Method";
        }
        [Route("Emp/ById")]
        public string GetEmployeeById()
        {
            return "Response from GetEmployeesById Method";
        }
    }
}
