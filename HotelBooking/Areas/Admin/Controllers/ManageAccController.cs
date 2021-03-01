using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;
using System.Data.SqlClient;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class ManageAccController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/ManageAcc/

        public ActionResult Index()
        {
            var model = context.Users.Where(x => x.Id_User != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/ManageAcc/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/ManageAcc/Create

        public ActionResult Create()
        {
            return View();
        }

        //Search Acc follow Tên người
        [HttpPost]
        public ActionResult SearchAcc(string name)
        {
            List<User> model = new List<User>();
            if (name == "")
            {
                model = context.Users.Where(x => x.Id_User != null).ToList();
            }
            else
            {
                model = context.Users.Where(x => x.Name == name).ToList();
            }

            return View("Index", model);
        }

        //
        // POST: /Admin/ManageAcc/Create

        [HttpPost]
        public ActionResult Create(User model)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageAcc/Edit/5

        public ActionResult Edit(int id)
        {
            var model = context.Users.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/ManageAcc/Edit/5

        [HttpPost]
        public ActionResult Edit(User model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.Users.Find(model.Id_User);
                obj.Id_User = model.Id_User;
                obj.UserName = model.UserName;
                obj.PassWord = model.PassWord;
                obj.Permission = model.Permission;

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageAcc/Delete/5

        public ActionResult Delete(int id)
        {
            var model = context.Users.Find(id);
            return View("Edit", model);
        }

        //
        // POST: /Admin/ManageAcc/Delete/5

        [HttpPost]
        public ActionResult Delete(User model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.Users.Find(model.Id_User);
                obj.UserName = obj.PassWord = null;
                
                //context.Users.Remove(obj);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
