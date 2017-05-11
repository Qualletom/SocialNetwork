using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class BllConversation
    {
        public int ConversationId { get; set; }
        public int UnreadCount { get; set; }
        public int? UserFromId { get; set; }
        public int? UserToId { get; set; }
        public BllMessage LastMessage { get; set; }
    }
}
