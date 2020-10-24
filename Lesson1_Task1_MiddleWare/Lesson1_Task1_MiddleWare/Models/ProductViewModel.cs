 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;
using WebStore.Domain.Entities.Base.Interfaces;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        //Свойствва, приходящие из Get-запроса в браузер
        public int Id { get; set; }
        public string Name { get; set; }        
        public int Order { get; set; }        
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
    }

}
