using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class CartViewModel
    {
        public Dictionary<ProductViewModel, int> Items { get; set; }
        public int ItemsCount => Items?.Sum(x => x.Value) ?? 0;
    }

}
