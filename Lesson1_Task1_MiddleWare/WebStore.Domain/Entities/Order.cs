using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities
{
    [Table("Orders")]
    public class Order : NamedEntity
    {
        public User User { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public virtual Collection<OrderItem> OrderItems { get; set; }
    }
}
