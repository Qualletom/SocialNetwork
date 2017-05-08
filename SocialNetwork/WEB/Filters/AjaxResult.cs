using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WEB.Filters
{
    public class AjaxResult : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.Result = filterContext.Result = new RedirectToRouteResult(new
                           RouteValueDictionary(new { controller = "EditProfile", action = "Edit", area = "" }));
            }

            base.OnActionExecuting(filterContext);
        }
    }
}