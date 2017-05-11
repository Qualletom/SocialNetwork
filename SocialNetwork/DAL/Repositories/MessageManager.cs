using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class MessageManager : IMessageManager
    {
        private readonly ApplicationContext _applicationContext;
        private int _pageSize = 20;

        public MessageManager(ApplicationContext context)
        {
            _applicationContext = context;
        }
        public IEnumerable<Message> GetAll()
        {
            return _applicationContext.Messages;
        }

        public Message Get(int id)
        {
            return _applicationContext.Messages.Find(id);
        }

        public IEnumerable<Message> Find(Func<Message, bool> predicate)
        {
            return _applicationContext.Messages.Where(predicate).ToList();
        }

        public void Create(Message item)
        {
            _applicationContext.Messages.Add(item);
        }

        public void Update(Message item)
        {
            _applicationContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var message = _applicationContext.Messages.Find(id);
            if (message != null)
                _applicationContext.Messages.Remove(message);
        }

        public IEnumerable<Message> GetConversationMessages(int conversationId, int page = 0)
        {
            var messagesToSkip = page*_pageSize;
            return _applicationContext.Messages
                .Where(message => message.ConversationId == conversationId)
                .OrderBy(message => message.MessageId)
                .Skip(messagesToSkip)
                .Take(_pageSize)
                .ToList();
        }

        public Message GetLastConversationMessage(int conversationId)
        {
            return _applicationContext.Messages
                .FirstOrDefault(message => message.ConversationId == conversationId);
        }
    }
}
