using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class manageGalleryController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/manageGallery/

        public ActionResult ManageGallery()
        {
            var model = context.Galleries.Where(x => x.Id_Glr != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/manageGallery/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchGal(string IdGal)
        {
            List<Gallery> model = new List<Gallery>();
            if (IdGal == "")
            {
                model = context.Galleries.Where(x => x.Id_Glr != null).ToList();
            }
            else
            {
                model = context.Galleries.Where(x => x.Id_Glr == IdGal).ToList();
            }

            return View("ManageGallery", model);
        }

        //
        // GET: /Admin/manageGallery/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/manageGallery/Create

        [HttpPost]
        public ActionResult CreateGal(Gallery model)
        {
            try
            {
                // TODO: Add insert logic here
                context.Galleries.Add(model);
                context.SaveChanges();
                return RedirectToAction("ManageGallery");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/manageGallery/Edit/5

        public ActionResult Edit(int id)
        {
            var model = context.Galleries.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/manageGallery/Edit/5

        [HttpPost]
        public ActionResult Edit(Gallery model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.Galleries.Find(model.Id_Glr);
                obj.ImageLink = model.ImageLink;
                obj.Active = model.Active;

                context.SaveChanges();
                return RedirectToAction("ManageGallery");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/manageGallery/Delete/5

        public ActionResult Delete(int id)
        {
            var model = context.Galleries.Find(id);
            return View("Edit", model);
        }

        //
        // POST: /Admin/manageGallery/Delete/5

        [HttpPost]
        public ActionResult Delete(Gallery model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.Galleries.Find(model.Id_Glr);
                context.Galleries.Remove(obj);
                context.SaveChanges();
                return RedirectToAction("ManageGallery");
            }
            catch
            {
                return View();
            }
        }
    }
}
