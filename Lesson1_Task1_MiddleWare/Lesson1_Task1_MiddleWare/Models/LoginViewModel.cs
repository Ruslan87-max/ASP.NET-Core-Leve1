using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Вы не ввели имя пользователя"), StringLength(200)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Вы не ввели пароль")] 
        [StringLength(6), DataType(dataType:DataType.Password)]
        public string Password { get; set; }

        [DataType(dataType: DataType.Url)]
        public string UrlReturn { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
