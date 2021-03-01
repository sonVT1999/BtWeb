using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class manageServicesController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/manageServices/

        public ActionResult ManageServices()
        {
            var model = context.Services.Where(x => x.Id_Service != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/manageServices/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchSer(string nameSer)
        {
            List<Service> model = new List<Service>();
            if (nameSer == "")
            {
                model = context.Services.Where(x => x.Id_Service != null).ToList();
            }
            else
            {
                model = context.Services.Where(x => x.Name == nameSer).ToList();
            }

            return View("ManageServices", model);
        }

        //
        // GET: /Admin/manageServices/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/manageServices/Create

        [HttpPost]
        public ActionResult CreatSer(Service model)
        {
            try
            {
                // TODO: Add insert logic here
                context.Services.Add(model);
                context.SaveChanges();
                return RedirectToAction("ManageServices");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/manageServices/Edit/5

        public ActionResult Edit(string id)
        {
            var model = context.Services.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/manageServices/Edit/5

        [HttpPost]
        public ActionResult Edit(Service model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.Services.Find(model.Id_Service);
                obj.Name = model.Name;
                obj.Image_service = model.Image_service;
                obj.Active = model.Active;

                context.SaveChanges();
                return RedirectToAction("ManageServices");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/manageServices/Delete/5

        public ActionResult Delete(string id)
        {
            var model = context.Services.Find(id);
            return View("Edit", model);
        }

        //
        // POST: /Admin/manageServices/Delete/5

        [HttpPost]
        public ActionResult Delete(Service model)
        {
            try
            {
                var tmp = context.ImageServices.Find(model.Id_Service);
                if (tmp != null)
                {
                    context.ImageServices.Remove(tmp);
                }

                // TODO: Add delete logic here
                var obj = context.Services.Find(model.Id_Service);
                context.Services.Remove(obj);
                context.SaveChanges();
                return RedirectToAction("ManageServices");
            }
            catch
            {
                return View();
            }
        }
    }
}
