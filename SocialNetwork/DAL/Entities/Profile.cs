using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }

        public byte[] Avatar { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MobilePhone { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? BirthDate { get; set; }

        public string BirthPlace { get; set; }
        public string Occupation { get; set; }

        [Required]
        public GenderEnum Gender { get; set; }

        public string Status { get; set; }
        public string About { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }

        //public ApplicationUser ApplicationUser { get; set; }

        public List<Language> Languages { get; set; }
    }
}
