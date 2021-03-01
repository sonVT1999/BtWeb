using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;
using HotelBooking.ViewModels;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class ManageImageRoomsController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/ManageImageRooms/

        public ActionResult Index()
        {
            var model = context.RoomViewForCartModels.Where(x => x.Id_image != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/ManageImageRooms/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //Search imageRoom follow idRoom
        [HttpPost]
        public ActionResult SearchImage(string idRoom)
        {
            List<ImageRoom> model = new List<ImageRoom>();
            if (idRoom == "")
            {
                model = context.ImageRooms.Where(x => x.Id_image != null).ToList();
            }
            else
            {
                model = context.ImageRooms.Where(x => x.Id_Room == idRoom).ToList();
            }

            return View("Index", model);
        }

        //
        // GET: /Admin/ManageImageRooms/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/ManageImageRooms/Create

        [HttpPost]
        public ActionResult CreateImage(ImageRoom model)
        {
            try
            {
                // TODO: Add insert logic here
                context.ImageRooms.Add(model);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageImageRooms/Edit/5

        public ActionResult Edit(string id)
        {
            var model = context.ImageRooms.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/ManageImageRooms/Edit/5

        [HttpPost]
        public ActionResult Edit(ImageRoom model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.ImageRooms.Find(model.Id_image);
                obj.Id_image = model.Id_image;
                obj.Id_Room = model.Id_Room;
                obj.imageLink = model.imageLink;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageImageRooms/Delete/5

        public ActionResult Delete(string id)
        {
            var model = context.ImageRooms.Find(id);
            return View("Edit", model);
        }

        //
        // POST: /Admin/ManageImageRooms/Delete/5

        [HttpPost]
        public ActionResult Delete(ImageRoom model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.ImageRooms.Find(model.Id_image);
                context.ImageRooms.Remove(obj);
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
