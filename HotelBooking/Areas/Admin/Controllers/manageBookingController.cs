using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class manageBookingController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/manageBooking/

        public ActionResult ManageBooking()
        {
            var model = context.Bookings.Where(x => x.Id_Booking != null).ToList();
            return View(model);

        }

        //public List<BookingViewModel> ListBooking()
        //{
        //    var model = from a in context.Bookings
        //                join b in context.Users on a.Id_Customer equals b.Id_User
        //                join c in context.BookingDetails on a.Id_Booking equals c.Id_Booking
        //                select new BookingViewModel()
        //                {
        //                    Id_Booking = a.Id_Booking,
        //                    NameCus = b.Name,
        //                    StartDay = c.StartDay,
        //                    EndDay = c.EndDay,
        //                    Note = a.Note,
        //                    Status = a.Status
        //                };

        //    return model.ToList();
        //}

        //
        // GET: /Admin/manageBooking/Details/5

        [HttpPost]
        public ActionResult SearchBooking(int Booking)
        {
            List<Booking> model = new List<Booking>();
            if (Booking == null)
            {
                model = context.Bookings.Where(x => x.Id_Booking != null).ToList();
            }
            else
            {
                model = context.Bookings.Where(x => x.Id_Booking == Booking).ToList();
            }

            return View("ManageBooking", model);
        }

        public ActionResult Details(int id)
        {
            var model = context.BookingDetails.Where(x => x.Id_Booking == id).FirstOrDefault();
            return View(model);
        }

        //public ActionResult Details()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Details(string id)
        //{
        //    var model = context.BookingDetails.Where(x => x.Id_Booking == id);
        //    return View(model);
        //}

        //
        // GET: /Admin/manageBooking/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/manageBooking/Create

        //[HttpPost]
        //public ActionResult CreateBooking(Booking model)
        //{
        //    try
        //    {
        //         //TODO: Add insert logic here
        //        context.Bookings.Add(model);
        //        context.SaveChanges();
        //        return RedirectToAction("ManageBooking");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //
        // GET: /Admin/manageBooking/Edit/5

        //public ActionResult Edit(string id)
        //{
        //    var model = context.Bookings.Find(id);
        //    return View(model);
        //}

        //
        // POST: /Admin/manageBooking/Edit/5

        //[HttpPost]
        //public ActionResult Edit(Booking model)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here
        //        var obj = context.Bookings.Find(model.Id_Booking);
                
        //        obj.Status = model.Status;
        //        obj.Note = model.Note;
        //        obj.Id_Customer = model.Id_Customer;
                
        //        context.SaveChanges();
        //        return RedirectToAction("ManageBooking");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //
        // GET: /Admin/manageBooking/Delete/5

        public ActionResult Delete(string id)
        {
            var model = context.Bookings.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/manageBooking/Delete/5

        [HttpPost]
        public ActionResult Delete(Booking model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.Bookings.Find(model.Id_Booking);
                context.Bookings.Remove(obj);
                context.SaveChanges();
                return RedirectToAction("ManageBooking");
            }
            catch
            {
                return View();
            }
        }
    }
}
