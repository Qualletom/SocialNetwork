using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Interfaces;

namespace BLL.Services
{
    public class DialogService : IDialogService
    {
        private readonly IUnitOfWork _database;

        public DialogService(IUnitOfWork database)
        {
            _database = database;
        }
        public void Dispose()
        {
            _database.Dispose();
        }

        public IEnumerable<BllMessage> GetDialogMessages(int dialogId, int page = 0)
        {
            return _database.MessageManager.GetConversationMessages(dialogId, page).ToBllMessagesList();
        }
    }
}
