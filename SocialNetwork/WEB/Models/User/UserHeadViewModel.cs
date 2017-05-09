using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models.User
{
    public class UserHeadViewModel
    {
        public int Id { get; set; }
        public byte[] Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}