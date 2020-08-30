using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Univercity { get; set; } 
        public string FacultyName { get; set; } 
        public string Date { get; set; } //Дата поступления
    }
}
