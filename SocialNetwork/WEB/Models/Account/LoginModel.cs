using System.ComponentModel.DataAnnotations;

namespace WEB.Models.Account
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Поле не может быть пустым!")]
        [Display(Name = "Введите e-mail")]
        [EmailAddress(ErrorMessage = "Введен некорректный e-mail адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым!")]
        [Display(Name = "Введите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}