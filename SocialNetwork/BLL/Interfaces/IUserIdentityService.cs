using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Infrastructure;

namespace BLL.Interfaces
{
    public interface IUserIdentityService : IDisposable
    {
        Task<OperationDetails> Create(BllRegisterUser bllUser);
        Task<ClaimsIdentity> Authenticate(UserDTO userDto);
        Task SetInitData();
    }
}
