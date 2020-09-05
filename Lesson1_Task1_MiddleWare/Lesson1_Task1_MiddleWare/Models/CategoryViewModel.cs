using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Base.Interfaces;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class CategoryViewModel : INamedEntity, IOrderedEntity
    {
        public CategoryViewModel()
        {
            ChildCategories = new List<CategoryViewModel>();
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Order { get; set; }

        /// <summary>
        /// Дочерние секции
        /// </summary>
        public List<CategoryViewModel> ChildCategories { get; set; }

        /// <summary>
        /// Родительские секции
        /// </summary>
        public CategoryViewModel ParentCategory { get; set; }
    }
}
