using System;
using System.ComponentModel.DataAnnotations;
using DAL.Entities;

namespace WEB.Models.Profile
{
    public class ProfileModel
    {
        public int Id { get; set; }

        public byte[] Avatar { get; set; }

        [Required (ErrorMessage = "Поле Имя не может быть пустым") ]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле Фамилия не может быть пустым")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Мобильный телефон")]
        public string MobilePhone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Дата рождения")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Родной город")]
        public string BirthPlace { get; set; }

        [Display(Name = "Должность")]
        public string Occupation { get; set; }

        [Required]
        public GenderEnum Gender { get; set; }
        //public string Status { get; set; }

        [Display(Name = "Кратко о себе")]
        public string About { get; set; }

        public string FullName => FirstName + " " + LastName;
    }
}