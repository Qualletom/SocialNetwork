using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Entities;
using DAL.Entities.Identity;
using DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Identity
{
    public class ApplicationUserStore : UserStore<ApplicationUser, ApplicationRole,int,ApplicationUserLogin,ApplicationUserRole,ApplicationUserClaim>,IApplicationUserStore
    {
        public ApplicationUserStore() : base(new ApplicationContext())
        {
            
        }
        public ApplicationUserStore(ApplicationContext context) : base(context)
        {
        }
    }
}
