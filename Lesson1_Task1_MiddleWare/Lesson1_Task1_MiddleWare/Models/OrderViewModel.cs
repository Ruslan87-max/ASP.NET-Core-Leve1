using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class OrderViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required, DataType(dataType: DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
