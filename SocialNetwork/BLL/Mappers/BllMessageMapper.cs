using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Mappers
{
    public static class BllMessageMapper
    {
        public static Message ToDalMessage(this BllMessage bllMessage)
        {
            if (bllMessage == null)
                return null;
            Message message = new Message()
            {
                MessageId = bllMessage.MessageId,
                Text = bllMessage.Text,
                Time = bllMessage.Time,
                IsRead = bllMessage.IsRead,
            };
            return message;
        }

        public static BllMessage ToBllMessage(this Message message)
        {
            if (message == null)
                return null;
            BllMessage bllMessage = new BllMessage()
            {
                MessageId = message.MessageId,
                Text = message.Text,
                Time = message.Time,
                IsRead = message.IsRead,
            };
            return bllMessage;
        }

        public static List<BllMessage> ToBllMessagesList(this List<Message> messages)
        {
            List<BllMessage> bllMessages = new List<BllMessage>();
            foreach (var message in messages)
            {
                bllMessages.Add(message.ToBllMessage());
            }
            return bllMessages;
        }
    }
}
