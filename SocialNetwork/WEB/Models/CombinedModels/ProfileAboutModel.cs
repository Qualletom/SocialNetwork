using WEB.Models.Profile;

namespace WEB.Models.CombinedModels
{
    public class ProfileAboutModel
    {
        public ProfileModel ProfileModel { get; set; }
        public InterestsModel InterestsModel { get; set; }

        public ProfileAboutModel(ProfileModel profileModel, InterestsModel interestsModel)
        {
            this.ProfileModel = profileModel;
            this.InterestsModel = interestsModel;
        }
    }
}