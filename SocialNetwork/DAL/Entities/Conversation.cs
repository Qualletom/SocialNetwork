using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Conversation
    {
        [Key]
        public int ConversationId { get; set; }

        public int UnreadCount { get; set; }

        [ForeignKey("ToUser")]
        public int? UserFromId { get; set; }
        [ForeignKey("FromUser")]
        public int? UserToId { get; set; }

        public virtual ApplicationUser FromUser { get; set; }

        public virtual ApplicationUser ToUser { get; set; }

        public List<Message> Messages { get; set; }
    }
}
