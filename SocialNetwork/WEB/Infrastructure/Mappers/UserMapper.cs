using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.DTO;
using WEB.Models;
using WEB.Models.Account;
using WEB.Models.User;

namespace WEB.Infrastructure.Mappers
{
    public static class UserMapper
    {
        public static BllRegisterUser ToBllRegisterUser(this RegisterModel registerModel)
        {
            BllRegisterUser bllRegisterUser = new BllRegisterUser()
            {
                Email = registerModel.Email,
                Password = registerModel.Password,
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                //Role = "user",
                Gender = registerModel.Gender
            };
            return bllRegisterUser;
        }

        public static UserModel ToUserModel(this BllUser bllUser)
        {
            if (bllUser == null)
                return null;
            UserModel userModel = new UserModel()
            {
                Id = bllUser.Id,
                //LastName = bllUser.LastName,
                //FirstName = bllUser.FirstName,
                Avatar = bllUser.Avatar,
                ProfileId = bllUser.ProfileId,
                Profile = bllUser.BllProfile.ToWebProfile(),
                InterestsId = bllUser.InterestsId,
                Interests = bllUser.BllInterest.ToWebInterests(),
            };
            return userModel;
        }

        public static UserHeadViewModel ToUserHeadModel(this BllUser bllUser)
        {
            if (bllUser == null)
                return null;
            UserHeadViewModel userHeadViewModel = new UserHeadViewModel()
            {
                Id = bllUser.Id,
                //LastName = bllUser.LastName,
                //FirstName = bllUser.FirstName,
                Avatar = bllUser.Avatar,
                FirstName = bllUser.FirstName,
                LastName = bllUser.FirstName
            };
            return userHeadViewModel;
        }


    }
}