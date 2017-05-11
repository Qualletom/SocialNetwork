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
        private readonly ApplicationContext _applicationContext;

        public UnitOfWork(string connectionString)
        {
            _applicationContext = new ApplicationContext(connectionString);
            UserManager = new ApplicationUserManager(new ApplicationUserStore(_applicationContext));
            RoleManager = new ApplicationRoleManager(new ApplicationRoleStore(_applicationContext));
            ClientManager = new ClientManager(_applicationContext);
            ProfileManager = new ProfileManager(_applicationContext);
            InterestsManager = new InterestsManager(_applicationContext);
            FriendManager = new FriendManager(_applicationContext);
            ConversationManager = new ConversationManager(_applicationContext);
            MessageManager = new MessageManager(_applicationContext);
        }
        public ApplicationRoleManager RoleManager { get; }
        public ApplicationUserManager UserManager { get; }
        public IClientManager ClientManager { get; }
        public IProfileManager ProfileManager { get; set; }
        public IInterestsManager InterestsManager { get; }
        public IFriendManager FriendManager { get; set; }
        public IConversationManager ConversationManager { get; }
        public IMessageManager MessageManager { get; }

        public async Task SaveAsync()
        {
            await _applicationContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _applicationContext.Dispose();
                }
                this._disposed = true;
            }
        }
    }
}
