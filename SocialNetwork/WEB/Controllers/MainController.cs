using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using WEB.Infrastructure.Mappers;
using WEB.Models.CombinedModels;
using WEB.Models.User;
using WEB.Models.Profile;

namespace WEB.Controllers
{
    public class MainController : Controller
    {
        private readonly IUserService _userService;
        private readonly IInterestsService _interestsService;
        private readonly IProfileService _profileService;

        public MainController(IUserService userService, IInterestsService interestsService, IProfileService profileService)
        {
            this._userService = userService;
            this._interestsService = interestsService;
            this._profileService = profileService;
        }
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Profile(int id)
        //{

        //}

        public ActionResult UserProfile(int id)
        {

            UserModel userModel = _userService.GetUserById(id).ToUserModel();
            InterestsModel interestsModel = userModel.Interests;
            ProfileModel profileModel = userModel.Profile;
            ProfileAboutModel profileAboutModel = new ProfileAboutModel(profileModel, interestsModel);
            UserProfileModel userProfileModel = new UserProfileModel(userModel, profileAboutModel);
            //InterestsModel interestsModel = userProfileService.GetInterestsByUserId(id).ToWebInterests();
            //ProfileModel profileModel = userProfileService.GetProfileByUserId(id).ToWebProfile();
           
            if (Request.IsAjaxRequest())
                return PartialView("", profileAboutModel);
            return View("_UserProfilePartial", profileAboutModel);
        }

        
        public ActionResult LeftMenu(int id)
        {
            UserModel userModel = _userService.GetUserById(id).ToUserModel();
            return PartialView("_LeftMenuPartial", userModel);
        }
    }
}