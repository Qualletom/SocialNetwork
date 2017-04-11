using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNet.Identity;

namespace BLL.Services
{
    class UserService : IUserService
    {
        private IUnitOfWork Database { get; set; }

        public UserService(IUnitOfWork database)
        {
            Database = database;
        }
        public void Dispose()
        {
            Database.Dispose();
        }

        public async Task<OperationDetails> Create(UserDTO userDto)
        {
            ApplicationUser user = await Database.UserManager.FindByEmailAsync(userDto.Email);
            if (user == null)
            {
                user = new ApplicationUser {Email = userDto.Email, UserName = userDto.Email, FirstName = userDto.FirstName, LastName = userDto.LastName};

                try
                {
                    var result = await Database.UserManager.CreateAsync(user, userDto.Password);
                    if (result.Errors.Any())
                    {
                        return new OperationDetails(false,result.Errors.FirstOrDefault(),"");
                    }
                    await Database.UserManager.AddToRolesAsync(user.Id, "user");
                    await Database.SaveAsync();
                    return new OperationDetails(true, "Вы успешно прошли регистрацию!", "");
                }
                catch (Exception ex)
                {
                    return new OperationDetails(false, ex.Message, "");
                }
            }
            else
            {
                return new OperationDetails(false,"Пользователь с таким логином уже существует","");
            }
        }

        public async Task<ClaimsIdentity> Authenticate(UserDTO userDto)
        {
            ClaimsIdentity claim = null;
            ApplicationUser user = await Database.UserManager.FindByEmailAsync(userDto.Email);
            if (user != null)
            {
                claim =
                    await Database.UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            }
            return claim;
        }

        public async Task SetInitData()
        {
            //ApplicationRole roleAdmin = new ApplicationRole {Id = "1", Name = "admin"};
            ApplicationRole roleUser = new ApplicationRole { Id = "2", Name = "user" };
            List<ApplicationRole> roles = Database.RoleManager.Roles.ToList();
            //await Database.RoleManager.DeleteAsync(new ApplicationRole {Id = "1", Name = "admin"});
            //await Database.RoleManager.CreateAsync(roleAdmin);
            
            await Database.RoleManager.CreateAsync(roleUser);
            //roles = Database.RoleManager.Roles;
        }
    }
}
