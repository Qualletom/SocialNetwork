using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        public string Text { get; set; }

        public bool IsRead { get; set; }

        [ForeignKey("ApplicationUser")]
        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Time { get; set; }

        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }

    }
}
