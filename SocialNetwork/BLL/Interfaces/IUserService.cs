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
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(BllUser bllUser);
        Task<ClaimsIdentity> Authenticate(UserDTO userDto);
        Task SetInitData();
    }
}
