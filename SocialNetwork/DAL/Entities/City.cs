using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class City
    {
        public int CityId { get; set; }

        [Required]
        public string Name { get; set; }

        public int CountryId { get; set; }

        [Required]
        public Country Country { get; set; }

        public List<Profile> Profiles { get; set; }
    }
}
