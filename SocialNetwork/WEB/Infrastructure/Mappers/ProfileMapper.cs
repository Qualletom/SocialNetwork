using System.Collections.Generic;
using BLL.DTO;
using WEB.Models.Profile;

namespace WEB.Infrastructure.Mappers
{
    public static class ProfileMapper
    {
        public static ProfileModel ToWebProfile(this BllProfile bllProfile)
        {
            if (bllProfile == null)
                return null;
            ProfileModel profileModel = new ProfileModel()
            {
                Id = bllProfile.Id,
                Avatar = bllProfile.Avatar,
                LastName = bllProfile.LastName,
                FirstName = bllProfile.FirstName,
                MobilePhone = bllProfile.MobilePhoneNumber,
                BirthDate = bllProfile.BirthDate,
                BirthPlace = bllProfile.BirthPlace,
                Occupation = bllProfile.Occupation,
                Gender = bllProfile.Gender,
                //Status = bllProfile.s
                About = bllProfile.About
            };
            return profileModel;
        }

        public static BllProfile ToBllProfile(this ProfileModel profileModel)
        {
            if (profileModel == null)
                return null;
            BllProfile bllProfile = new BllProfile()
            {
                Id = profileModel.Id,
                Avatar = profileModel.Avatar,
                LastName = profileModel.LastName,
                FirstName = profileModel.FirstName,
                MobilePhoneNumber = profileModel.MobilePhone,
                BirthDate = profileModel.BirthDate,
                BirthPlace = profileModel.BirthPlace,
                Occupation = profileModel.Occupation,
                Gender = profileModel.Gender,
                //Status = bllProfile.s
                About = profileModel.About
            };
            return bllProfile;
        }

        public static List<ProfileModel> ToWebProfileList(this List<BllProfile> bllProfiles)
        {
            List<ProfileModel> profileModels = new List<ProfileModel>();
            foreach (var bllProfile in bllProfiles)
            {
                profileModels.Add(bllProfile.ToWebProfile());
            }
            return profileModels;
        }


    }
}