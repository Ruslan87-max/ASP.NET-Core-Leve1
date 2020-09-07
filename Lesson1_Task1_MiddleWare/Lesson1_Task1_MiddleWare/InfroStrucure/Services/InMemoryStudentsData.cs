using Lesson1_Task1_MiddleWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.InfroStrucure
{
    /// <summary>
    /// Реализация интерфейса, хранит информацию в памяти
    /// </summary>
    public class InMemoryStudentsData : IStudentsService
    {
        //private readonly StudentsList studentsList = new StudentsList();

        public List<Student> studentsList = new List<Student>();
        public InMemoryStudentsData()
        {
            studentsList.Add(new Student() { Id = 1, Name = "Владимир", SurName = "Иванов", Status = "Аспирант", Univercity = "МГУ", FacultyName = "Факультет психологии", Date = new DateTime(2015, 08, 22) });
            studentsList.Add(new Student() { Id = 2, Name = "Ирина", SurName = "Петрова", Status = "Магистр", Univercity = "МИРЭА", FacultyName = "Информатика и вычислительная техника", Date = new DateTime(2012, 09, 1) });
            studentsList.Add(new Student() { Id = 3, Name = "Антон", SurName = "Поляков", Status = "Студент", Univercity = "МИРЭА", FacultyName = "Программная инженерия", Date = new DateTime(2015, 07, 30) });
        }
        public void AddNew(Student model)
        {
            model.Id = studentsList.Max(model => model.Id) + 1;
            studentsList.Add(model);
        }

        public void Commit()
        {
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var student = GetById(id);
            if (student == null)
                return;
            else
                studentsList.Remove(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return studentsList;
        }

        public Student GetById(int id)
        {
            return studentsList.FirstOrDefault(e => e.Id.Equals(id));
        }
    }
}
