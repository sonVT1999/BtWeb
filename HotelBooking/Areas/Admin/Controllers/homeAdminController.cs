using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;
namespace HotelBooking.Areas.Admin.Controllers
{
    public class homeAdminController : Controller
    {
        public class MyViewModel
        {
            public int cusCount { get; set; }
            public int roomCount { get; set; }
            public int serviceCount { get; set; }
            public int bookingCount { get; set; }
        }

        public class ViewCountModel
        {
            public int bookingCount { get; set; }
            public double? total { get; set; }
        }
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/homeAdmin/

        public ActionResult Index()
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                var viewModel = new MyViewModel();
                viewModel.cusCount = (from a in context.Users
                                      where a.Permission == false
                                      select new { a.Id_User }).Count();
                viewModel.roomCount = (from a in context.Rooms
                                       where a.Id_Room != null
                                       select new { a.Id_Room }).Count();
                viewModel.serviceCount = (from a in context.Services
                                          where a.Id_Service != null
                                          select new { a.Id_Service }).Count();
                viewModel.bookingCount = (from a in context.Bookings
                                          where a.Id_Booking != null
                                          select new { a.Id_Booking }).Count();
                return View(viewModel);
            }
        }

        //
        // GET: /Admin/homeAdmin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // Thống kê tần suất đặt phòng
        public ActionResult BookingStatistics()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookingStatistics(string roomTypeName, DateTime? fromDate, DateTime? toDate)
        {
            try
            {
                ViewBag.tungay = fromDate;
                ViewBag.denngay = toDate;
                ViewBag.tenloaiphong = roomTypeName;
                var model = new ViewCountModel();
                //var model = context.BookingDetails.Where(x => x.Room.Name == roomName && x.StartDay > fromDate && x.EndDay <= toDate).ToList();
                model.bookingCount = (from a in context.BookingDetails
                                      where a.Room.RoomType.Name == roomTypeName && a.StartDay >= fromDate && a.EndDay <= toDate
                                      select new { a.Id }).Count();
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        //Thống kê doanh thu
        public ActionResult BillStatistics()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BillStatistics(DateTime? fromDate, DateTime? toDate)
        {
            try
            {
                ViewBag.tungay = fromDate;
                ViewBag.denngay = toDate;
                var model = new ViewCountModel();
                model.total = context.BookingDetails.Where(x => x.StartDay >= fromDate && x.EndDay <= toDate).Sum(x => x.Total_Amount);
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/homeAdmin/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/homeAdmin/Create

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
        // GET: /Admin/homeAdmin/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/homeAdmin/Edit/5

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
        // GET: /Admin/homeAdmin/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/homeAdmin/Delete/5

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
