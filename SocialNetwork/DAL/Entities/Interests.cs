using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Interests
    {
        [Key]
        public int InterestsId { get; set; }

        public string Hobbies { get; set; }
        public string TvShows { get; set; }
        public string Movies { get; set; }
        public string Games { get; set; }
        public string Bands { get; set; }
        public string Books { get; set; }
        public string Writers { get; set; }
        public string Other { get; set; }
       // public ApplicationUser ApplicationUser { get; set; }
    }
}
