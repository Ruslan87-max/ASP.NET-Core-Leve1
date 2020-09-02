using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1_Task1_MiddleWare.Controllers
{
    public class StudentController : Controller 
    {
        StudentsList studentsList = new StudentsList();
        public IActionResult Index1()
        {
            return View(studentsList.students);
        }

        public IActionResult StudentDetails1(int id)
        {
            var _students = studentsList.students.FirstOrDefault(x => x.Id.Equals(id));
            return View(_students == null ? null : _students);
        }
    }
}
