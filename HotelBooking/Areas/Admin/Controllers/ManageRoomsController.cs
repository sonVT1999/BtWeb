using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;
using System.Data.SqlClient;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class ManageRoomsController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/ManageRooms/

        public ActionResult Index()
        {
            var model = context.Rooms.Where(x => x.Id_Room != null && x.Id_Type != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/ManageRooms/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //Search Room follow RoomName
        [HttpPost]
        public ActionResult SearchRooms(string roomName)
        {
            List<Room> model = new List<Room>();
            if (roomName == "")
            {
                model = context.Rooms.Where(x => x.Id_Room != null && x.Id_Type != null).ToList();
            }
            else
            {
                model = context.Rooms.Where(x => x.Name == roomName).ToList();
            }

            return View("Index", model);
        }

        //
        // GET: /Admin/ManageRooms/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/ManageRooms/Create

        [HttpPost]
        public ActionResult CreateRoom(Room model)
        {
            try
            {
                // TODO: Add insert logic here
                context.Rooms.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageRooms/Edit/5

        public ActionResult Edit(string id)
        {
            var model = context.Rooms.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/ManageRooms/Edit/5

        [HttpPost]
        public ActionResult Edit(Room model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.Rooms.Find(model.Id_Room);
                obj.Name = model.Name;
                obj.Price = model.Price;
                obj.Status = model.Status;

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageRooms/Delete/5

        public ActionResult Delete(string id)
        {
            var model = context.Rooms.Find(id);
            return View("Edit", model);
        }

        //
        // POST: /Admin/ManageRooms/Delete/5

        [HttpPost]
        public ActionResult Delete(Room model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.Rooms.Find(model.Id_Room);
                context.Rooms.Remove(obj);
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
