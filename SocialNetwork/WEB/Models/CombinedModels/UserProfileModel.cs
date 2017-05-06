using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEB.Models.User;

namespace WEB.Models.CombinedModels
{
    public class UserProfileModel
    {
        public UserModel UserModel { get; set; }
        public ProfileAboutModel ProfileAboutModel { get; set; }

        public UserProfileModel(UserModel userModel, ProfileAboutModel profileAboutModel)
        {
            this.UserModel = userModel;
            this.ProfileAboutModel = profileAboutModel;
        }
    }
}