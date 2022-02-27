using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRSystem.data;
using HRSystem.Models;

namespace HRSystem.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            HRContext context = new HRContext();
            List<City> licity = (from e in context.city
                               select e).ToList();
            List<Country> licountry = (from e in context.country
                               select e).ToList();
            List<Department> lidepartment = (from e in context.department
                               select e).ToList();
            VMemployee vm = new VMemployee();
            vm.licity = licity;
            vm.licountry = licountry;
            vm.lidepartment = lidepartment;

            return View("Employeeinfo",vm);
        }
        public IActionResult saveinfo(VMemployee vm)
        {
            HRContext context = new HRContext();
            context.employee.Add(vm.employee);
            context.SaveChanges();
            List<City> licity = (from e in context.city
                                 select e).ToList();
            List<Country> licountry = (from e in context.country
                                       select e).ToList();
            List<Department> lidepartment = (from e in context.department
                                             select e).ToList();
           
            vm.licity = licity;
            vm.licountry = licountry;
            vm.lidepartment = lidepartment;
            return View("Employeeinfo",vm);
        }
        public IActionResult showlist()
        {
            List<Employee> liemployee = new List<Employee>();
            return View("Employeelist",liemployee);
        }
        public IActionResult elist()
        {
            string name = Request.Form["name"];
            HRContext context = new HRContext();
            List<Employee> liemployee = (from e in context.employee
                                         where e.FName == name
                                         select e).ToList();
            
            return View("Employeelist", liemployee);
        }
        public IActionResult deleteinfo(Employee emp)
        {
           
            HRContext context = new HRContext();
            
            emp = context.employee.Find(emp.Id);
            context.employee.Remove(emp);
            context.SaveChanges();
            return View("Employeelist");
        }
        public IActionResult editinfo()
        {
            return View("Employeelist");
        }

    }
}
