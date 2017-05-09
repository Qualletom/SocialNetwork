using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using Microsoft.AspNet.Identity;
using WEB.Infrastructure.Mappers;
using WEB.Models;
using WEB.Models.CombinedModels;
using WEB.Models.Profile;
using WEB.Models.User;

namespace WEB.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IInterestsService _interestsService;
        private readonly IProfileService _profileService;

        public ProfileController( IInterestsService interestsService, IProfileService profileService)
        {
            this._interestsService = interestsService;
            this._profileService = profileService;
        }

        [HttpGet]
        public ActionResult ShowUser(int? id)
        {
            if (id == null)
            {
                if (User.Identity.IsAuthenticated)
                {
                    id = Convert.ToInt32(User.Identity.GetUserId());
                    RouteData.Values["id"] = id;
                }
                else
                    return RedirectToAction("Login", "Join");
            }
            if (Request.IsAjaxRequest())
                return PartialView("_UserPagePartial");
            return View("_UserPagePartial");
        }

        [HttpGet]
        public ActionResult UserProfile(int id)

        {

            InterestsModel interestsModel = _interestsService.GetInterestsByUserId(id).ToWebInterests();
            ProfileModel profileModel = _profileService.GetProfileByUserId(id).ToWebProfile();
            ProfileAboutModel profileAboutModel = new ProfileAboutModel(profileModel, interestsModel);
            //if (Request.IsAjaxRequest() || TempData["call"] != null)
            //    return PartialView("_UserProfilePartial", profileAboutModel);
            //return View("_UserPagePartial");
            if (Request.IsAjaxRequest() || TempData["call"] != null)
                return PartialView("_UserProfilePartial", profileAboutModel);
            return View("_UserPagePartial");
        }

        //[HttpGet]
        //public ActionResult 
    }
}