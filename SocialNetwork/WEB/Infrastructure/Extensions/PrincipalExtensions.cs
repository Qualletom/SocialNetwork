using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;

namespace WEB.Infrastructure.Extensions
{
    public static class PrincipalExtensions
    {
        public static string GetFullName(this System.Security.Principal.IPrincipal usr)
        {
            var fullNameClaim = ((ClaimsIdentity)usr.Identity).FindFirst("First");
            if (fullNameClaim != null)
                return fullNameClaim.Value;

            return "";
        }

        public static bool IsShowMenuForm(this System.Security.Principal.IPrincipal usr, int id)
        {
            var userIdentity = usr.Identity;
            if (userIdentity.IsAuthenticated && int.Parse(userIdentity.GetUserId()) == id)
                    return false;
            return true;
        }
    }
}