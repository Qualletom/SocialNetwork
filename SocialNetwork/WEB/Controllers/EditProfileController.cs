using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using WEB.Filters;
using WEB.Infrastructure.Mappers;
using WEB.Models.Profile;

namespace WEB.Controllers
{
    public class EditProfileController : Controller
    {
        private readonly IProfileService _profileService;
        private readonly IInterestsService _interestsService;
        public EditProfileController(IProfileService profileService, IInterestsService interestsService)
        {
            this._profileService = profileService;
            this._interestsService = interestsService;
        }


        [HttpGet]
        public ActionResult Edit()
        {
            if (Request.IsAjaxRequest() || TempData["call"] != null)
                return PartialView("_ProfileMenuSettings");
            return View("_UserPagePartial");
        }

        [HttpGet]
        public ActionResult Personal()
        {
            int userId = Convert.ToInt32(User.Identity.GetUserId());
            ProfileModel profileModel = _profileService.GetProfileByUserId(3).ToWebProfile();
            return PartialView("_PersonalInfoPartial", profileModel);
        }

        [HttpGet]
        public ActionResult Hobbies()
        {
            int userId = Convert.ToInt32(User.Identity.GetUserId());
            InterestsModel interestsModel = _interestsService.GetInterestsByUserId(userId).ToWebInterests();
            return PartialView("_HobbiesPartial", interestsModel);
        }

        [HttpPost]
        public ActionResult SavePersonal(ProfileModel profileModel)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = "Success";
                _profileService.UpdateProfile(profileModel.ToBllProfile());
                UpdateUserClaims(profileModel.FirstName);
            }
                
            return PartialView("_PersonalInfoPartial");
        }

        [HttpPost]
        public ActionResult SaveHobbies(InterestsModel interestsModel)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = "Success";
                _interestsService.UpdateInterests(interestsModel.ToBllIneInterests());
            }
            return PartialView("_HobbiesPartial");
        }


        private async Task UpdateUserClaims(string userName)
        {
            var identity = (ClaimsIdentity)User.Identity;
            identity.RemoveClaim(identity.FindFirst("FirstName"));
            identity.AddClaim(new Claim("FirstName", userName));

            // Call AddClaim, AddClaims or RemoveClaim on the user identity.

            IOwinContext context = Request.GetOwinContext();
            IAuthenticationManager authenticationManager = HttpContext.GetOwinContext().Authentication;

            var authenticationContext =
                await context.Authentication.AuthenticateAsync(DefaultAuthenticationTypes.ApplicationCookie);

            if (authenticationContext != null)
            {
                authenticationManager.AuthenticationResponseGrant = new AuthenticationResponseGrant(
                    identity,
                    authenticationContext.Properties);
            }
        }
    }
}