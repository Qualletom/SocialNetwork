using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class UserProfileService :IUserProfileService
    {
        private readonly IUnitOfWork _database;

        public UserProfileService(IUnitOfWork database)
        {
            _database = database;
        }
        public void Dispose()
        {
            _database.Dispose();
        }

        public BllProfile GetProfileByUserId(int userId)
        {
            return _database.ProfileManager.Get(userId).ToBllProfile();
        }

        public BllInterest GetInterestsByUserId(int userId)
        {
            return _database.InterestsManager.Get(userId).ToBllIneInterests();
        }

    }
}
