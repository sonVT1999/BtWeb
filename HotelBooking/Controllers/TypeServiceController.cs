using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelBooking.Controllers
{
    public class TypeServiceController : Controller
    {
        //
        // GET: /TypeService/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /TypeService/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TypeService/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TypeService/Create

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
        // GET: /TypeService/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TypeService/Edit/5

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
        // GET: /TypeService/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TypeService/Delete/5

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
