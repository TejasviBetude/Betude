using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_V01.Models;
using Assignment_V01.Controllers;

namespace Assignment_V01.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employee
        EmployeeContext context = new EmployeeContext();
        public ActionResult Index()
        {
            return View(context.Employees.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                if(ModelState.IsValid)
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            return View(employee);
            
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                // TODO: Add update logic here
                Employee emp = context.Employees.FirstOrDefault(e => e.EmployeeId == id);
                emp.EmployeeId = employee.EmployeeId;
                emp.Name = employee.Name;
                emp.Age = employee.Age;
                emp.Gender = employee.Gender;
                emp.Location = employee.Location;
                emp.Salary = employee.Salary;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                // TODO: Add delete logic here
                Employee emp1 = context.Employees.FirstOrDefault(e => e.EmployeeId == id);
                context.Employees.Remove(employee);
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
