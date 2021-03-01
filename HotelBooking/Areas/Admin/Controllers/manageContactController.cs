using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class manageContactController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/manageContact/

        public ActionResult ManageContact()
        {
            var model = context.Contacts.Where(x => x.Id_Contact != null).ToList();
            return View(model);
        }

        //
        // GET: /Admin/manageContact/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Searchcontact(int Id_Contact)
        {
            List<Contact> model = new List<Contact>();
            if (Id_Contact == null)
            {
                model = context.Contacts.Where(x => x.Id_Contact != null).ToList();
            }
            else
            {
                model = context.Contacts.Where(x => x.Id_Contact == Id_Contact).ToList();
            }

            return View("ManageContact", model);
        }

        //
        // GET: /Admin/manageContact/Create

        //
        // GET: /Admin/manageContact/Edit/5


        //
        // GET: /Admin/manageContact/Delete/5

        public ActionResult Delete(int id)
        {
            var model = context.Contacts.Find(id);
            return View(model);
        }

        //
        // POST: /Admin/manageContact/Delete/5

        [HttpPost]
        public ActionResult Delete(Contact model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.Contacts.Find(model.Id_Contact);
                context.Contacts.Remove(obj);
                context.SaveChanges();
                return RedirectToAction("ManageContact");
            }
            catch
            {
                return View();
            }
        }
    }
}
