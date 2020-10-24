using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.InfroStrucure;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1_Task1_MiddleWare.Controllers
{
    [Authorize]
    [Route("Users")]
    public class StudentController : Controller
    {
        private readonly IStudentsService _studentsService;
        public StudentController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        StudentsList studentsList = new StudentsList();

        [Route("all")]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_studentsService.GetAll());
        }

        [Route("{id?}")]
        [Authorize(Roles = "Admins,User")]
        public IActionResult StudentDetails(int id)
        {
            //var _students = studentsList.students.FirstOrDefault(x => x.Id.Equals(id));
            //return View(student == null ? null : _students);
            var student = _studentsService.GetById(id);

            if (ReferenceEquals(student, null))
                return NotFound();//возвращаем результат 404 Not Found

            //Иначе возвращаем сотрудника
            return View(student);
        }

        [HttpGet]
        [Route("edit/{id?}")]
        [Authorize(Roles = "Admins")]
        public IActionResult Edit(int? id)
        {
            Student studentModel;
            if (id.HasValue)
            {
                studentModel = _studentsService.GetById(id.Value);
                if (ReferenceEquals(studentModel, null))
                    return NotFound();// возвращаем результат 404 Not Found
            }
            else
            {
                studentModel = new Student();
            }
            return View(studentModel);

        }

        [HttpPost]
        [Route("edit/{id?}")]
        [Authorize(Roles = "Admins")]
        public IActionResult Edit(Student studentModel)
        {
            if (studentModel.Date > new DateTime(2020, 08, 30))
                ModelState.AddModelError("Date", "Дата поступления не может быть позднее крайней даты зачисления \"30.08.2020\"");

            if (ModelState.IsValid)
            {
                if (studentModel.Id > 0)
                {
                    var dbItem = _studentsService.GetById(studentModel.Id);

                    if (ReferenceEquals(dbItem, null))
                        return NotFound();// возвращаем результат 404 Not Found

                    dbItem.Name = studentModel.Name;
                    dbItem.SurName = studentModel.SurName;
                    dbItem.Univercity = studentModel.Univercity;
                    dbItem.FacultyName = studentModel.FacultyName;
                    dbItem.Date = studentModel.Date;

                    studentModel = dbItem;
                }
                else
                {
                    _studentsService.AddNew(studentModel);
                }

                _studentsService.Commit();

                return RedirectToAction("Index");
            }
            return View(studentModel);
        }
        
        [HttpGet]
        [Route("delete/{id?}")]
        [Authorize(Roles = "Admins")]
        public IActionResult Delete(int? id)
        {
            if (id.Value > 0)
            {
                var dbItem = _studentsService.GetById(id.Value);
                if (dbItem != null)
                    return View(dbItem);
            }
            return NotFound();
        }

        
        [HttpPost]
        [Route("delete/{id?}")]
        [Authorize(Roles = "Admins")]
        public IActionResult Delete(Student studentModel)
        {
            if (studentModel.Id > 0)
            {
                var dbItem = _studentsService.GetById(studentModel.Id);
                if (dbItem != null)
                {
                    _studentsService.Delete(studentModel.Id);
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
