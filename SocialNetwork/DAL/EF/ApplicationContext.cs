﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string connectionString) : base(connectionString)
        {
            
        }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }

    //public class UserDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    //{
    //    protected override void Seed(ApplicationContext db)
    //    {
    //        db.Roles.Add(new ApplicationRole { Id = "1", Name = "admin" });
    //        db.Roles.Add(new ApplicationRole { Id = "2", Name = "user" });
    //        base.Seed(db);
    //    }
    //}
}
