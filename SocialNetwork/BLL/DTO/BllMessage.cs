using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class BllMessage
    {
        public int MessageId { get; set; }
        public string Text { get; set; }
        public bool IsRead { get; set; }
        public int UserId { get; set; }
        public BllUser BllUser { get; set; }
        public DateTime Time { get; set; }
        public int ConversationId { get; set; }
    }
}
