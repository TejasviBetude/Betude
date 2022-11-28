using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Security_hw.Models;
using Security_hw.Controllers;
using System.Web.Security;


namespace Security_hw.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
       
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User usermodel)
        {
            using (MVC_DB_hwEntities entities = new MVC_DB_hwEntities())
            {
                bool IsValidUser = entities.Users.Any(user => user.UserName.ToLower() == usermodel.UserName
                  && user.UserPassword == usermodel.UserPassword);

                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(usermodel.UserName, false); //browser cookie will capture the user name for sometime if you want to store it permanently write true or else write false
                    return RedirectToAction("Index", "Employees");
                }

                ModelState.AddModelError("", "Invalid user name or password");
                return View();
            }
        }
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User user)
        {
            using (MVC_DB_hwEntities entities = new MVC_DB_hwEntities())
            {
                entities.Users.Add(user);
                entities.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
           
        }
    }
}