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
    public class InterestsService : IInterestsService
    {
        private readonly IUnitOfWork _database;

        public InterestsService(IUnitOfWork database)
        {
            _database = database;
        }
        public BllInterest GetInterestsByUserId(int id)
        {
            return _database.InterestsManager.Get(id).ToBllIneInterests();
        }

        public void UpdateInterests(BllInterest bllInterest)
        {
            _database.InterestsManager.Update(bllInterest.ToDalIneInterests());
            _database.SaveAsync();
        }

        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
