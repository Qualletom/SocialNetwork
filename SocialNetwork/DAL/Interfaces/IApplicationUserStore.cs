using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNet.Identity;

namespace DAL.Interfaces
{
    public interface IApplicationUserStore : IUserStore<ApplicationUser, int>
    {
    }
}
