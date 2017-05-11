using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Identity;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationRoleManager RoleManager { get; }
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        IProfileManager ProfileManager { get; }
        IInterestsManager InterestsManager { get; }
        IFriendManager FriendManager { get; }
        IConversationManager ConversationManager { get; }
        IMessageManager MessageManager { get; }
        Task SaveAsync();
    }
}
