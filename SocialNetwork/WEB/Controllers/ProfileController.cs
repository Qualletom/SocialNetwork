using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using WEB.Mappers;
using WEB.Models;
using WEB.Models.CombinedModels;

namespace WEB.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUserProfileService userProfileService;

        public ProfileController(IUserProfileService userProfileService)
        {
            this.userProfileService = userProfileService;
        }
        // GET: Profile
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult ShowUser(int id)
        {
            InterestsModel interestsModel = userProfileService.GetInterestsByUserId(id).ToWebInterests();
            ProfileModel profileModel = userProfileService.GetProfileByUserId(id).ToWebProfile();

            ProfileAboutModel profileAboutModel = new ProfileAboutModel(profileModel,interestsModel);
            return View("_UserProfilePartial",profileAboutModel);
        }
    }
}