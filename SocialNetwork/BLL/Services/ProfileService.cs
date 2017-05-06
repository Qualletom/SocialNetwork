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
    public class ProfileService : IProfileService
    {
        private readonly IUnitOfWork _database;

        public ProfileService(IUnitOfWork database)
        {
            _database = database;
        }
        public void Dispose()
        {
            _database.Dispose();
        }

        public BllProfile GetProfileByUserId(int id)
        {
            return _database.ProfileManager.Get(id).ToBllProfile();
        }
    }
}
