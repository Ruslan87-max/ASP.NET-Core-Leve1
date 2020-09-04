using Lesson1_Task1_MiddleWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.InfroStrucure
{
    public interface IStudentsService
    {
        /// <summary>
        /// Получение списка студентов
        /// </summary>
        /// <returns></returns>
        IEnumerable<Student> GetAll();

        /// <summary>
        /// Получение студентов по id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        Student GetById(int id);
        /// <summary>
        /// Сохранить изменения
        /// </summary>
        void Commit();

        /// <summary>
        /// Добавить нового студента
        /// </summary>
        /// <param name="model"></param>
        void AddNew(Student model);

        /// <summary>
        /// Удалить позицию
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
