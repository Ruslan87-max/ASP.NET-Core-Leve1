using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class EmployeesList
    {
        public List<Employee> employees = new List<Employee>();

        public EmployeesList()
        {
            employees.Add(new Employee() { Id = 1, Name="Александр", Age=25, Position="Junior-C#-developer"});
            employees.Add(new Employee() { Id = 2, Name = "Константин", Age = 30, Position = "Senior-C#-developer" });
            employees.Add(new Employee() { Id = 3, Name = "Иван", Age = 35, Position = "Руководитель проекта" });
        }
    }
}
