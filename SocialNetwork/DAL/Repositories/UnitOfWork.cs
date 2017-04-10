using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Entities;
using DAL.Identity;
using DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext _applicationContext;

        public UnitOfWork(string connectionString)
        {
            _applicationContext = new ApplicationContext(connectionString);
            UserManager = new ApplicationUserManager(new UserStore<ApplicationUser>(_applicationContext));
            RoleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(_applicationContext));
            ClientManager = new ClientManager(_applicationContext);
        }
        public ApplicationRoleManager RoleManager { get; }
        public ApplicationUserManager UserManager { get; }
        public IClientManager ClientManager { get; }
        public async Task SaveAsync()
        {
            await _applicationContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    UserManager.Dispose();
                    RoleManager.Dispose();
                    ClientManager.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}
