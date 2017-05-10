using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WEB.Infrastructure.Extensions
{
    public static class RouteDataExtensions
    {
        public static object IdRouteValue(this RouteData routeData)
        {
            if (routeData.Values["id"] != null)
                return new {id = (routeData.Values["id"])};
            return null;
        }
    }
}