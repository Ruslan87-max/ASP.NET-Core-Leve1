using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    [Table("Products")]
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")] //Обозначает свойство, используемое в связи c сущностью "Categories" в качестве внешнего ключа.
        public virtual Category Categories { get; set; }
        public int? BrandId { get; set; }
        //public int? SomeField { get; set; }

        [ForeignKey("BrandId")] //Обозначает свойство, используемое в связи c сущностью "Brands" в качестве внешнего ключа.
        public virtual Brand Brands { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
