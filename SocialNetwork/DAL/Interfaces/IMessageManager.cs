using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IMessageManager : IRepository<Message>
    {
        IEnumerable<Message> GetConversationMessages(int conversationId, int page = 0);

        Message GetLastConversationMessage(int conversationId);
    }
}
