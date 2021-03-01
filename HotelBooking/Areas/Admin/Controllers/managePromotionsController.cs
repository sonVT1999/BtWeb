using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class managePromotionsController : Controller
    {
        //
        // GET: /Admin/managePromotions/
        private MyDbContext context = new MyDbContext();

        public ActionResult managePromotions()
        {
            var model = context.Promotions.Where(x => x.Id_Prom != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/managePromotions/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchProms(string Id_Prom)
        {
            List<Promotion> model = new List<Promotion>();
            if (Id_Prom == "")
            {
                model = context.Promotions.Where(x => x.Id_Prom != null).ToList();
            }
            else
            {
                model = context.Promotions.Where(x => x.Id_Prom == Id_Prom).ToList();
            }

            return View("managePromotions", model);
        }
        //
        // GET: /Admin/managePromotions/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/managePromotions/Create

        [HttpPost]
        public ActionResult CreateProms(Promotion model)
        {
            try
            {
                // TODO: Add insert logic here
                context.Promotions.Add(model);
                context.SaveChanges();
                return RedirectToAction("managePromotions");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/managePromotions/Edit/5

        public ActionResult Edit(string id)
        {
            var model = context.Promotions.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/managePromotions/Edit/5

        [HttpPost]
        public ActionResult Edit(Promotion model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.Promotions.Find(model.Id_Prom);
                obj.Title = model.Title;
                obj.ImageLink = model.ImageLink;
                obj.Detail = model.Detail;
                obj.Active = model.Active;

                context.SaveChanges();
                return RedirectToAction("managePromotions");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/managePromotions/Delete/5

        public ActionResult Delete(string id)
        {
            var model = context.Promotions.Find(id);
            return View("Edit", model);
        }

        //
        // POST: /Admin/managePromotions/Delete/5

        [HttpPost]
        public ActionResult Delete(Promotion model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.Promotions.Find(model.Id_Prom);
                context.Promotions.Remove(obj);
                context.SaveChanges();
                return RedirectToAction("managePromotions");
            }
            catch
            {
                return View();
            }
        }
    }
}
