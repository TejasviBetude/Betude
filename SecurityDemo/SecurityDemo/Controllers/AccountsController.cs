﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SecurityDemo.Models;
namespace SecurityDemo.Controllers
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
            using (MVC_DB_TEntities entities = new MVC_DB_TEntities())
            {
                bool IsValidUser = entities.Users.Any(
                    user => user.UserName.ToLower() == usermodel.UserName
                    && user.UserPassword == usermodel.UserPassword);

                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(usermodel.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }
                ModelState.AddModelError("", "Invalid Username or Password");
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
            using (MVC_DB_TEntities entites = new MVC_DB_TEntities())
            {
                entites.Users.Add(user);
                entites.SaveChanges();
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