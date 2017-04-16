using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WEB.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Введите e-mail")]
        [EmailAddress(ErrorMessage = "Введен некорректный e-mail адрес")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Введите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}