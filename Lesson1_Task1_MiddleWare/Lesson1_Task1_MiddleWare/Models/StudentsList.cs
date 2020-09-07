using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class StudentsList
    {
        public List<Student> students = new List<Student>();

        public StudentsList()
        {
            students.Add(new Student() { Id = 1, Name = "Владимир", SurName = "Иванов", Status = "Аспирант", Univercity = "МГУ", FacultyName = "Факультет психологии", Date = new DateTime(2015, 08, 22) });
            students.Add(new Student() { Id = 2, Name = "Ирина", SurName = "Петрова", Status = "Магистр", Univercity = "МИРЭА", FacultyName = "Информатика и вычислительная техника", Date = new DateTime(2012, 09, 1) });
            students.Add(new Student() { Id = 3, Name = "Антон", SurName = "Поляков", Status="Студент", Univercity = "МИРЭА", FacultyName = "Программная инженерия", Date = new DateTime(2015, 07, 30) });
        }
    }
}
