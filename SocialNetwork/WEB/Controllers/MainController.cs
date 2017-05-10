using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using BLL.Interfaces;
using Microsoft.AspNet.Identity;
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
        
        public ActionResult LeftMenu(int? id)
        {
            int userId = id ?? User.Identity.GetUserId().AsInt();
            //int id = RouteData.Values["id"]?.ToString().AsInt() ?? User.Identity.GetUserId().AsInt();
            UserHeadViewModel userHeadViewModel = _userService.GetUserById(userId).ToUserHeadModel();
            return PartialView("_UserMenuPartial", userHeadViewModel);
        }
    }
}