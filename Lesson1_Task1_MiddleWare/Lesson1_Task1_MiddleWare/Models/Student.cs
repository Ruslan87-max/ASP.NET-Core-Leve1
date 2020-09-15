using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя является обязательным", AllowEmptyStrings = false)]
        [Display(Name ="Имя")]
        [StringLength(200, MinimumLength=2, ErrorMessage = "В имени должно быть не менее 2х и не более 200 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Фамилие является обязательным", AllowEmptyStrings = false)]
        [Display(Name = "Фамилие")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "В имени должно быть не менее 2х и не более 200 символов")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Статус является обязательным", AllowEmptyStrings = false)]
        [Display(Name = "Статус")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "В имени должно быть не менее 2х и не более 200 символов")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Университет является обязательным", AllowEmptyStrings = false)]
        [Display(Name = "Университет")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "В имени должно быть не менее 2х и не более 200 символов")]
        public string Univercity { get; set; }

        [Required(ErrorMessage = "Факультет является обязательным", AllowEmptyStrings = false)]
        [Display(Name = "Факультет")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "В имени должно быть не менее 2х и не более 200 символов")]
        public string FacultyName { get; set; }

        [Required(ErrorMessage = "Дата поступления в университет является обязательным", AllowEmptyStrings = false)]
        [Display(Name = "Дата поступления")]
        [DataType(dataType: DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode=true)]
        public DateTime Date { get; set; } //Дата поступления
    }
}
