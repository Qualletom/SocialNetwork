using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WEB.Filters;
using WEB.Infrastructure.Mappers;
using WEB.Models;
using WEB.Models.Account;

namespace WEB.Controllers
{
    [OnlyNotAuthorized]
    public class JoinController : Controller
    {
        private readonly IUserIdentityService _userService;

        public JoinController(IUserIdentityService userService)
        {
            _userService = userService;
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public ActionResult Login()
        {
            if (Request.IsAjaxRequest())
                return PartialView("_LoginFormPartial");
            ViewBag.method = "login";
            return View("_LoginFormPartial", masterName: "_JoinLayout");
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserDTO userDto = new UserDTO { Email = model.Email, Password = model.Password };
                ClaimsIdentity claim = await _userService.Authenticate(userDto);
                if (claim == null)
                {
                    ModelState.AddModelError("", "Неверный логин или пароль.");
                }
                else
                {
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("_LoginFormPartial", masterName: "_JoinLayout");
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            if (Request.IsAjaxRequest())
                return PartialView("_RegisterFormPartial");
            ViewBag.method = "register";
            return View("_RegisterFormPartial", masterName: "_JoinLayout");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                BllUser bllUser = model.ToBllUser();
                //UserDTO userDto = new UserDTO
                //{
                //    Email = model.Email,
                //    Password = model.Password,
                //    FirstName = model.FirstName,
                //    LastName = model.LastName,
                //    Role = "user"
                //};
                OperationDetails operationDetails = await _userService.Create(bllUser);
                if (operationDetails.Succedeed)
                {
                    return RedirectToAction("Index", "Home");

                }
                ModelState.AddModelError(operationDetails.Property, operationDetails.Message);

            }
            return View("_RegisterFormPartial", masterName: "_JoinLayout");
        }
        private async Task SetInitialDataAsync()
        {
            await _userService.SetInitData();
        }

        [Authorize]
        public ActionResult CheckRegister()
        {
            return View("Error");
        }

        //GET: Account
        public ActionResult Index()
        {
            return View();
        }
    }
}