using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Entities
{
    public class ApplicationUser : IdentityUser<int,ApplicationUserLogin, ApplicationUserRole,ApplicationUserClaim>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Created { get; set; }

   
        public int ProfileId { get; set; }

        public virtual Profile Profile { get; set; }

        public int InterestsId { get; set; }
        public virtual Interests Interests { get; set; }
    }
}
