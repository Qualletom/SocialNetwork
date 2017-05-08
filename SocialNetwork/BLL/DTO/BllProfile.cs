using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.DTO
{
    public class BllProfile
    {
        public int Id { get; set; }
        public byte[] Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Occupation { get; set; }
        public GenderEnum Gender { get; set; }
        //public string Status { get; set; }
        public string About { get; set; }
    }
}
