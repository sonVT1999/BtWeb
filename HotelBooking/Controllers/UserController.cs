using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        MyDbContext db;
        public ActionResult Index()
        {
            return View();
        }
        List<User> getlstUser()
        {
            db = new MyDbContext();
            var lst = db.Users.ToList();
            return lst;
        }
    }
}
