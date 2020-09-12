using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    /// <summary>
    /// Доменный класс моделей
    /// </summary>
    [Table("Categories")]
    public class Category : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        public int? ParentID { get; set; }

        [ForeignKey("ParentID")] //Обозначает свойство, используемое в связи с сущностью "Categories" в качестве внешнего ключа.
        public virtual Category Categories { get; set; }
        public int Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
