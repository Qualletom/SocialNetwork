using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BLL.DTO;
using WEB.Models.Profile;

namespace WEB.Models.User
{
    public class UserModel
    {
        public int Id { get; set; }
        public byte[] Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int ProfileId { get; set; }
        public ProfileModel Profile { get; set; }
        public int InterestsId { get; set; }
        public InterestsModel Interests { get; set; }
        public SexEnum Gender { get; set; }
    }
}