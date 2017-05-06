using System;
using System.ComponentModel.DataAnnotations;
using DAL.Entities;

namespace WEB.Models.Profile
{
    public class ProfileModel
    {

        public int Id { get; set; }

        [Required]
        public byte[] Avatar { get; set; }
        public string MobilePhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Occupation { get; set; }
        [Required]
        public GenderEnum Gender { get; set; }
        //public string Status { get; set; }
        public string About { get; set; }
    }
}