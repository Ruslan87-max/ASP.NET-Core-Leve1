using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class CatalogViewModel
    {
        public int? BrandId { get; set; }
        public int? CategorydId { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
