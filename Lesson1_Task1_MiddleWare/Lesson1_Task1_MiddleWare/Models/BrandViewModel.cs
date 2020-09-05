using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;
using WebStore.Domain.Entities.Base.Interfaces;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Order { get; set; }
        public int Count { get; set; } //Количество товаров по BrandId

        public List<Product> Products;
        public BrandViewModel()
        {
            Products = new List<Product>();
        }

    }
}
