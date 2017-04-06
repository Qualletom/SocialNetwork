using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class ClientManager : IClientManager
    {
        private readonly ApplicationContext _applicationContext;

        public ClientManager(ApplicationContext context)
        {
            _applicationContext = context;
        }
        public void Dispose()
        {
            _applicationContext.Dispose();
        }

        public void Create(ClientProfile profile)
        {
            _applicationContext.ClientProfiles.Add(profile);
            _applicationContext.SaveChanges();
        }
    }
}
