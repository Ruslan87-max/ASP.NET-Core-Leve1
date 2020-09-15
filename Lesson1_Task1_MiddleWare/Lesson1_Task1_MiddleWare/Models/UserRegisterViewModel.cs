using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Вы не ввели имя пользователя"), StringLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Вы не ввели пароль"), StringLength(6)]
        [DataType(dataType:DataType.Password), Compare(nameof(Password))]
        public string Password { get; set; }

        [Required(ErrorMessage = "Вы не подтвердили паролль")] 
        [StringLength(6), DataType(dataType: DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Вы не ввели e-mail")]
        [StringLength(256), DataType(dataType: DataType.EmailAddress)]
        public string EmailAdress { get; set; }
    }
}
