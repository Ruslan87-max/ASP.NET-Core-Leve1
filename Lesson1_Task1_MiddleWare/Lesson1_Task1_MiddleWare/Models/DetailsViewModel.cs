using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class DetailsViewModel
    {
        public OrderViewModel OrderViewModel { get; set; }
        public CartViewModel CartViewModel { get; set; }
    }
}
