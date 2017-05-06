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
    public class ApplicationRoleStore : RoleStore<ApplicationRole, int,ApplicationUserRole>, IApplicationRoleStore
    {
        public ApplicationRoleStore() : base(new ApplicationContext())
        {
            
        }
        public ApplicationRoleStore(ApplicationContext context) : base(context)
        {
        }
    }
}
