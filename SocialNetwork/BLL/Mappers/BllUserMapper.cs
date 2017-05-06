using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Mappers
{
    public static class BllUserMapper
    {
        public static ApplicationUser ToDalUser(this BllUser bllUser)
        {
            if (bllUser == null)
                return null;
            ApplicationUser user = new ApplicationUser()
            {
                Id = bllUser.Id,
                LastName = bllUser.LastName,
                FirstName = bllUser.FirstName,
                Avatar = bllUser.Avatar,
                ProfileId = bllUser.ProfileId,
                Profile = bllUser.BllProfile.ToDalProfile(),
                InterestsId = bllUser.InterestsId,
                Interests = bllUser.BllInterest.ToDalIneInterests(),
            };
            return user;
        }

        public static BllUser ToBllUser(this ApplicationUser applicationUser)
        {
            if (applicationUser == null)
                return null;
            BllUser bllUser = new BllUser()
            {
                Id = applicationUser.Id,
                LastName = applicationUser.LastName,
                FirstName = applicationUser.FirstName,
                Avatar = applicationUser.Avatar,
                ProfileId = applicationUser.ProfileId,
                BllProfile = applicationUser.Profile.ToBllProfile(),
                InterestsId = applicationUser.InterestsId,
                BllInterest = applicationUser.Interests.ToBllIneInterests(),
            };
            return bllUser;
        }
    }
}
