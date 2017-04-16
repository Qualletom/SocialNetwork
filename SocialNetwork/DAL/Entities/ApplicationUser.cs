using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Created { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public int InterestsId { get; set; }
        public Interests Interests { get; set; }
    }
}
