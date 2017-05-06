using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Interfaces;
using Microsoft.AspNet.Identity;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _database;

        public UserService(IUnitOfWork database)
        {
            _database = database;
        }
        public void Dispose()
        {
            _database.Dispose();
        }

        public BllUser GetUserById(int id)
        {
            return _database.UserManager.FindById(id).ToBllUser();
        }
    }
}
