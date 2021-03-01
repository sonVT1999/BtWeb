using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelBooking.Controllers
{
    public class RoomInforController : Controller
    {
        //
        // GET: /RoomInfor/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /RoomInfor/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /RoomInfor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RoomInfor/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
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
        // GET: /RoomInfor/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /RoomInfor/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RoomInfor/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /RoomInfor/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
