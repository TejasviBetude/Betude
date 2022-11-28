using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SecurityDemo.Controllers;
using SecurityDemo.Models;

namespace SecurityDemo.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}