using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Entities
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
