using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RequestDate { get; set; }

        [ForeignKey("ToUser")]
        public int? UserFromId { get; set; }
        [ForeignKey("FromUser")]
        public int? UserToId { get; set; }

        public bool? IsConfirmed { get; set; }

        public virtual ApplicationUser FromUser { get; set; }

        public virtual ApplicationUser ToUser { get; set; }
    }
}
