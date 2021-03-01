using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class ManageImageServicesController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/manageImageServices/

        public ActionResult Index()
        {
            var model = context.ImageServices.Where(x => x.Id_image != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/manageImageServices/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //Search imageServices follow idService
        [HttpPost]
        public ActionResult SearchServices(string idService)
        {
            List<ImageService> model = new List<ImageService>();
            if (idService == "")
            {
                model = context.ImageServices.Where(x => x.Id_image != null).ToList();
            }
            else
            {
                model = context.ImageServices.Where(x => x.Id_Service == idService).ToList();
            }

            return View("Index", model);
        }

        //
        // GET: /Admin/manageImageServices/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/manageImageServices/Create

        [HttpPost]
        public ActionResult CreateService(ImageService model)
        {
            try
            {
                // TODO: Add insert logic here
                context.ImageServices.Add(model);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/manageImageServices/Edit/5

        public ActionResult Edit(string id)
        {
            var model = context.ImageServices.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/manageImageServices/Edit/5

        [HttpPost]
        public ActionResult Edit(ImageService model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.ImageServices.Find(model.Id_image);
                obj.Id_image = model.Id_image;
                obj.Id_Service = model.Id_Service;
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
        // GET: /Admin/manageImageServices/Delete/5

        public ActionResult Delete(string id)
        {
            var model = context.ImageServices.Find(id);
            return View("Edit", model);
        }

        //
        // POST: /Admin/manageImageServices/Delete/5

        [HttpPost]
        public ActionResult Delete(ImageService model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.ImageServices.Find(model.Id_image);
                context.ImageServices.Remove(obj);
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
