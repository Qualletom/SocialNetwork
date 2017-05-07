using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class BllUser
    {
        public int Id { get; set; }
        public byte[] Avatar { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int ProfileId { get; set; }
        public BllProfile BllProfile { get; set; }
        public int InterestsId { get; set; }
        public BllInterest BllInterest { get; set; }    
        public SexEnum Gender { get; set; }
    }
}
