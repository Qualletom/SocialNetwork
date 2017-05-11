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
    public class ConversationManager : IConversationManager
    {
        private readonly ApplicationContext _applicationContext;
        private int _pageSize = 20;

        public ConversationManager(ApplicationContext context)
        {
            _applicationContext = context;
        }
        public IEnumerable<Conversation> GetAll()
        {
            return _applicationContext.Conversations;
        }

        public Conversation Get(int id)
        {
            return _applicationContext.Conversations.Find(id);
        }

        public IEnumerable<Conversation> Find(Func<Conversation, bool> predicate)
        {
            return _applicationContext.Conversations.Where(predicate).ToList();
        }

        public void Create(Conversation item)
        {
            _applicationContext.Conversations.Add(item);
        }

        public void Update(Conversation item)
        {
            _applicationContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var conversation = _applicationContext.Conversations.Find(id);
            if (conversation != null)
                _applicationContext.Conversations.Remove(conversation);
        }

        public IEnumerable<Conversation> GetConversationsPage(int userId, int page = 0)
        {
            var conversationsToSkip = page * _pageSize;
            return _applicationContext.Conversations
                .Where(conversation => conversation.UserFromId == userId)
                .OrderBy(conversation => conversation.ConversationId)
                .Skip(conversationsToSkip)
                .Take(_pageSize)
                .ToList();
        }
    }
}
