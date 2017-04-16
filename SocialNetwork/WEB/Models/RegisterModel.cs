using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class RegisterModel
    {
        [Required]
        [Display(Name = "Введите имя")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Введите фамилию")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Введите e-mail")]
        [EmailAddress(ErrorMessage = "Введен некорректный e-mail адрес")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Введите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Введите пароль ещё раз")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}