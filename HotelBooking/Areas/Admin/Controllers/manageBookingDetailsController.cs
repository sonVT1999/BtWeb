using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class manageBookingDetailsController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/manageBookingDetails/

        public ActionResult ManageBookingDetails()
        {
            var model = context.BookingDetails.Where(x => x.Id_Booking != null).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult SearchBookingDetail(int Id_Booking)
        {
            List<BookingDetail> model = new List<BookingDetail>();
            if (Id_Booking == null)
            {
                model = context.BookingDetails.Where(x => x.Id_Booking != null).ToList();
            }
            else
            {
                model = context.BookingDetails.Where(x => x.Id_Booking == Id_Booking).ToList();
            }

            return View("ManageBookingDetails", model);
        }

        //
        // GET: /Admin/manageBookingDetails/Details/5


        //
        // GET: /Admin/manageBookingDetails/Create


        //
        // GET: /Admin/manageBookingDetails/Edit/5


        //
        // GET: /Admin/manageBookingDetails/Delete/5

    }
}
