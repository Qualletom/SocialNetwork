using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNet.Identity;

namespace DAL.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser, int>
    {
        public ApplicationUserManager(IApplicationUserStore store) : base(store)
        {
        }
    }
}
