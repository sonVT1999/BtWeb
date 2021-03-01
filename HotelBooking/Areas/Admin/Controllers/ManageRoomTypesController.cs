using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class ManageRoomTypesController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/ManageRoomTypes/

        public ActionResult Index()
        {
            var model = context.RoomTypes.Where(x => x.Id_Type != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/ManageRoomTypes/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //Search Cus follow id
        [HttpPost]
        public ActionResult SearchRoomType(string name)
        {
            List<RoomType> model = new List<RoomType>();
            if (name == "")
            {
                model = context.RoomTypes.Where(x => x.Id_Type != null).ToList();
            }
            else
            {
                model = context.RoomTypes.Where(x => x.Name == name).ToList();
            }

            return View("Index", model);
        }

        //
        // GET: /Admin/ManageRoomTypes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/ManageRoomTypes/Create

        [HttpPost]
        public ActionResult CreateRoomType(RoomType model)
        {
            try
            {
                // TODO: Add insert logic here
                context.RoomTypes.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageRoomTypes/Edit/5

        public ActionResult Edit(string id)
        {
            var model = context.RoomTypes.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/ManageRoomTypes/Edit/5

        [HttpPost]
        public ActionResult Edit(RoomType model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.RoomTypes.Find(model.Id_Type);
                obj.Id_Type = model.Id_Type;
                obj.Name = model.Name;
                obj.Bed_Amount = model.Bed_Amount;
                obj.Size = model.Size;
                obj.Adult_Amount = model.Adult_Amount;
                obj.Children_Amount = model.Children_Amount;
                obj.Note = model.Note;

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageRoomTypes/Delete/5

        public ActionResult Delete(string id)
        {
            var model = context.RoomTypes.Find(id);
            return View("Edit", model);
        }

        //
        // POST: /Admin/ManageRoomTypes/Delete/5

        [HttpPost]
        public ActionResult Delete(RoomType model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.RoomTypes.Find(model.Id_Type);
                context.RoomTypes.Remove(obj);
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
