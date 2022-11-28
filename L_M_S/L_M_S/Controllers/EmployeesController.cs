using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using L_M_S.Models;
using L_M_S.Controllers;
    

namespace L_M_S.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        EmployeeContext context = new EmployeeContext();
        public ActionResult Index()
        {
            return View(context.employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            var employee = context.employees.FirstOrDefault(e => e.EmployeeId == id);
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                context.employees.Add(employee);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            Employee employee = context.employees.FirstOrDefault(e => e.EmployeeId == id);
            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                // TODO: Add update logic here
                Employee employee1 = context.employees.FirstOrDefault(e => e.EmployeeId == id);
                employee1.EmployeeId = employee.EmployeeId;
                employee1.Name = employee.Name;
                employee1.UserName = employee.UserName;
                employee1.Password = employee.Password;
                employee1.ConfirmPassword = employee.ConfirmPassword;
                context.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            Employee emp = context.employees.FirstOrDefault(e => e.EmployeeId == id);
            return View(emp);
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                // TODO: Add delete logic here
                Employee emp = context.employees.FirstOrDefault(e => e.EmployeeId == id);
                context.employees.Remove(emp);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
