using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.DTO;
using WEB.Models;
using WEB.Models.Account;

namespace WEB.Infrastructure.Mappers
{
    public static class UserMapper
    {
        public static BllUser ToBllUser(this RegisterModel registerModel)
        {
            BllUser bllUser = new BllUser()
            {
                Email = registerModel.Email,
                Password = registerModel.Password,
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Role = "user",
                Gender = registerModel.Gender
            };
            return bllUser;
        }
    }
}