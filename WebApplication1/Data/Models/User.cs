using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class User
    {
        //[HiddenInput (DisplayValue = false)]
        //[BindNever]
        [ScaffoldColumn(false)]
        public int Id { get; set; }


        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required (ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Возраст (в годах)")]
        [Range (0, 100, ErrorMessage = "Возраст должен быть в диапазоне от 0 до 100 лет")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Почта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Длина пароля должна быть не менее 8 символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
