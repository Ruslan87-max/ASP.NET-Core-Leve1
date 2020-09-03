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
            students.Add(new Student() { Id = 1, Name = "Владимир", SurName = "Иванов", Univercity = "МГУ", FacultyName = "Факультет психологии", Date = "1.09.2009" });
            students.Add(new Student() { Id = 2, Name = "Ирина", SurName = "Петрова", Univercity = "МИРЭА", FacultyName = "Информатика и вычислительная техника", Date = "1.09.2002" });
            students.Add(new Student() { Id = 3, Name = "Антон", SurName = "Поляков", Univercity = "МИРЭА", FacultyName = "Программная инженерия", Date = "1.09.2015" });
        }
    }
}
