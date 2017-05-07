using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Mappers
{
    public static class BllProfileMapper
    {
        public static Profile ToDalProfile(this BllProfile bllProfile)
        {
            if (bllProfile == null)
                return null;
            Profile profile = new Profile()
            {
                ProfileId = bllProfile.Id,
                //Avatar = bllProfile.Avatar,
                FirstName = bllProfile.FirstName,
                LastName = bllProfile.LastName,
                MobilePhone = bllProfile.MobilePhoneNumber,
                BirthDate = bllProfile.BirthDate,
                BirthPlace = bllProfile.BirthPlace,
                Occupation = bllProfile.Occupation,
                Gender = bllProfile.Gender,
                //Status = bllProfile.s
                About = bllProfile.About
            };
            return profile;
        }

        public static BllProfile ToBllProfile(this Profile profile)
        {
            if (profile == null)
                return null;
            BllProfile bllProfile = new BllProfile()
            {
                Id = profile.ProfileId,
                //Avatar = profile.Avatar,
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                MobilePhoneNumber = profile.MobilePhone,
                BirthDate = profile.BirthDate,
                BirthPlace = profile.BirthPlace,
                Occupation = profile.Occupation,
                Gender = profile.Gender,
                //Status = bllProfile.s
                About = profile.About
            };
            return bllProfile;
        }
    }
}
