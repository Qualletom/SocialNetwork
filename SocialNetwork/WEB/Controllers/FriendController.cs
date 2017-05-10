using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using WEB.Infrastructure.Mappers;
using WEB.Models.Profile;

namespace WEB.Controllers
{
    public class FriendController : Controller
    {
        private readonly IProfileService _profileService;
        public FriendController(IProfileService profileService)
        {
            this._profileService = profileService;
        }
        // GET: Friend
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Friends(int id)
        {

            if (Request.IsAjaxRequest() || TempData["call"] != null)
            {
                List<ProfileModel> profileModel = _profileService.GetConfirmedFriendsProfiles(id).ToWebProfileList();
                return PartialView("_FriendBlockPartial", profileModel);
            }
            return View("_UserPagePartial");
        }
    }
}