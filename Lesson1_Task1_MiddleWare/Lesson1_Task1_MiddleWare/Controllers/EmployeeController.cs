using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1_Task1_MiddleWare.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeesList employeesList = new EmployeesList();
        
        public IActionResult Index()
        {
            return View(employeesList.employees);
        }

        public IActionResult EmployeeDetails(int id)
        {
            var employees = employeesList.employees.FirstOrDefault(x => x.Id.Equals(id)); //В представление передаем данные 1-го сотрудника.

            if (employees == null)
                return NotFound(); 
            else
                return View(employees);

        }
    }
}
