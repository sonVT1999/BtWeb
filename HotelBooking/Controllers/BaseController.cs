using HotelBooking.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HotelBooking.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (SessionLogin)Session[UserSession.SessionU];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "home", action = "Login" }));

            }
            base.OnActionExecuting(filterContext);
        }
       



    }
}
