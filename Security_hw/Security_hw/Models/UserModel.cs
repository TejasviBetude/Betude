using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Security_hw.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
    }
}