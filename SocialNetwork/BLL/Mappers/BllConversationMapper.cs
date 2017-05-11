using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Mappers
{
    public static class BllConversationMapper
    {
        public static Conversation ToDalConversation(this BllConversation bllConversation)
        {
            if (bllConversation == null)
                return null;
            Conversation conversation = new Conversation()
            {
                ConversationId = bllConversation.ConversationId,
                
                //FriendId = bllFriend.FriendId,
                //UserFromId = bllFriend.UserFromId,
                //UserToId = bllFriend.UserToId,
                //IsConfirmed = bllFriend.IsConfirmed,
                //RequestDate = bllFriend.RequestDate,

            };
            return conversation;
        }

        public static BllConversation ToBllConversation(this Conversation conversation)
        {
            if (conversation == null)
                return null;
            BllConversation bllConversation = new BllConversation()
            {
                ConversationId = conversation.ConversationId,
                UserFromId = conversation.UserFromId,
                UserToId = conversation.UserToId,
                UnreadCount = conversation.UnreadCount
            };
            return bllConversation;
        }
    }
}
