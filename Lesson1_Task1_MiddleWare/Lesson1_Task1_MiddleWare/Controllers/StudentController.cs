using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.InfroStrucure;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1_Task1_MiddleWare.Controllers
{
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
        public IActionResult Index()
        {
            return View(_studentsService.GetAll());
        }

        [Route("{id?}")]
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
        public IActionResult Edit(Student studentModel)
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
            }
            else
            {
                _studentsService.AddNew(studentModel);
            }

            _studentsService.Commit();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id?}")]
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
