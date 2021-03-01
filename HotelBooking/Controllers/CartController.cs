using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Common;
using HotelBooking.Models;
using HotelBooking.ViewModels;
namespace HotelBooking.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /CartController/
        private MyDbContext context = new MyDbContext();
        public ActionResult Index()
        {
            ViewBag.ngayden = Session["ngayden"];
            ViewBag.ngaydi = Session["ngaydi"];
           
            var cart = (Cart)Session["CartSession"];
            if (cart == null)
            {
                cart = new Cart();
            }
            return View(cart);
        }

        [HttpPost]
        public ActionResult addBooking(Booking model, BookingDetail model2)
        {
            context.BookingDetails.Add(model2);
            context.Bookings.Add(model);
            context.SaveChanges();
            return RedirectToAction("index", "home");
        }

        
        public ActionResult xacnhan()
        {
            ViewBag.ngayden = Session["ngayden"];
            ViewBag.ngaydi = Session["ngaydi"];
            ViewBag.iduser = Session["usernameid"];
            return View();
        }

        public ActionResult AddItem(string id, string returnURL)
        {
            ViewBag.ngayden = Session["ngayden"];
            ViewBag.ngaydi = Session["ngaydi"];
            //var product = context.RoomViewForCartModels.Find(id);
            var product = context.RoomViewForCartModels.Where(x=>x.Id_Room == id).FirstOrDefault();
            var cart = (Cart)Session["CartSession"];
            if (cart != null)
            {
                cart.AddItem(product, 1);
                //Gán vào session
                Session["CartSession"] = cart;
            }
            else
            {
                //tạo mới đối tượng cart item
                cart = new Cart();
                cart.AddItem(product, 1);
                //Gán vào session
                Session["CartSession"] = cart;
            }

            if (string.IsNullOrEmpty(returnURL))
            {
                return RedirectToAction("Index");
            }
            return Redirect(returnURL);
        }

        //

        // GET: /Cart/Details/5
        public ActionResult RemoveLine(string id)
        {
            var product = context.RoomViewForCartModels.Where(x => x.Id_Room == id).FirstOrDefault();

            var cart = (Cart)Session["CartSession"];

            if (cart != null)
            {
                cart.RemoveLine(product);
                //Gán vào session
                Session["CartSession"] = cart;
            }
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCart(string[] maphong, int[] qty)
        {
            var cart = (Cart)Session["CartSession"];
            
            if (cart != null)
            {
                for (int i = 0; i < maphong.Count(); i++)
                {
                    var tmp = maphong[i];
                    var product = context.RoomViewForCartModels.Where(x => x.Id_Room == tmp).FirstOrDefault();
                    cart.UpdateItem(product, qty[i]);
                }

                Session["CartSession"] = cart;
            }

            return RedirectToAction("Index");

        }


        //
        // GET: /Cart/Details/5
        [HttpGet]
        public ActionResult Payment()
        {
            var cart = (Cart)Session["CartSession"];
            if (cart == null)
            {
                cart = new Cart();
            }
            return View(cart);
        }

        //[HttpPost]
        //public ActionResult Payment(HoaDon model)
        //{
        //    model.NgayHD = DateTime.Now;
        //    try
        //    {
        //        context.HoaDons.Add(model);
        //        context.SaveChanges();
        //        var cart = (Cart)Session["CartSession"];
        //        foreach (var item in cart.Lines)
        //        {
        //            ChiTietHD obj = new ChiTietHD();
        //            obj.MaHD = model.MaHD;
        //            obj.MaSP = item.Sanpham.MaSP;
        //            obj.DonGia = item.Sanpham.GiaSP;
        //            obj.SoLuong = item.Quantity;

        //            context.ChiTietHDs.Add(obj);
        //            context.SaveChanges();
        //        }
        //        cart.Clear();
        //        Session["CartSession"] = cart;
        //    }
        //    catch (Exception ex)
        //    {
        //        //ghi log
        //        return RedirectToAction("/Loi");
        //    }
        //    return View("Complete");
        //}

        
         //GET: /Cart/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cart/Create

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
        // GET: /Cart/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cart/Edit/5

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
        // GET: /Cart/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cart/Delete/5

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
