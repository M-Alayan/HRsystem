using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRSystem.data;
using HRSystem.Models;

namespace HRSystem.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            Department dpt = new Department();
            return View("dptinfo",dpt);
        }
        public IActionResult saveinfo(Department dpt)
        {
            
            HRContext context = new HRContext();
            context.department.Add(dpt);
            context.SaveChanges();
            dpt = new Department();
            return View("dptinfo",dpt);
        }
        public IActionResult showlist()
        {
            List<Department> lidpt = new List<Department>();
            return View("dptlist",lidpt);
        }

        public IActionResult dlist()
        {
            string name = Request.Form["name"];
            HRContext context = new HRContext();
            List<Department> lidpt = (from e in context.department
                                      where e.Name == name
                                      select e).ToList();
            return View("dptlist",lidpt);

        }
    }
}
