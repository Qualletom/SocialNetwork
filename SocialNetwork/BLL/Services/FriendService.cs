using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL.Interfaces;

namespace BLL.Services
{
    public class FriendService : IFriedService
    {
        private readonly IUnitOfWork _database;

        public FriendService(IUnitOfWork database)
        {
            _database = database;
        }
        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
