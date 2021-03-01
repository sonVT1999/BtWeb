using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using HotelBooking.Common;
using HotelBooking.Areas.Admin.Controllers;
using HotelBooking.Areas.Admin;
using HotelBooking.Models;
using HotelBooking.ViewModels;

namespace HotelBooking.Controllers
{
    public class homeController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /home/

        //------------------giao dien cua Dang Quang Dat
        MyDbContext db;
        List<User> getlstUser()
        {
            var lst = context.Users.ToList();
            return lst;
        }
        public List<banner> ListBanner() {

            return context.banners.Where(X => X.imageLink != null).ToList();
        }

        public List<RoomViewModel> ListRoom()
        {
            

                var model = from a in context.Rooms
                            join b in context.ImageRooms on a.Id_Room equals b.Id_Room
                            join c in context.RoomTypes on a.Id_Type equals c.Id_Type
                            select new RoomViewModel()
                            {
                                nameType = c.Name,
                                imageLink = b.imageLink,
                                price = a.Price,
                                bedAmount = c.Bed_Amount,
                                adultAmount = c.Adult_Amount,
                                childAmount = c.Children_Amount,
                                size = c.Size,
                                url = c.Note,
                                MASP = a.Id_Room,
                            };

                return model.ToList();
            
        }
        public List<previews> Previewws()
        {
            var model = from a in context.Rooms
                        join b in context.ImageRooms on a.Id_Room equals b.Id_Room
                        join c in context.RoomTypes on a.Id_Type equals c.Id_Type
                        join d in context.NotePreviews on c.Id_Type equals d.Id_Type
                        select new previews()
                        {
                            nameType = c.Name,
                            imageLink = b.imageLink,
                            note1 = d.Note1,
                            note2 = d.Note2,



                        };
            return model.ToList();
        }


        public List<Promotion> ListPromotion()
        {
            return context.Promotions.Where(X => X.Id_Prom != null).ToList();
        }
        public List<Introduce> ListIntro()
        {
            return context.Introduces.Where(X => X.Id != null).ToList();
        }
        public List<Gallery> ListGall()
        {
            return context.Galleries.Where(X => X.Id_Glr != null).ToList();
        }

        [HttpPost]
        public ActionResult Search(string Adult)
        {

            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                var model = context.SearchViews.Where(X => X.Adult_Amount.Contains(Adult)).ToList();
                //var model = context.SearchViews.Where(X => Convert.ToInt32(X.Adult_Amount) >= Adult).ToList();
                return View(model);
            }
        }


        [HttpPost]
        public ActionResult xacnhan(DateTime ngay1, DateTime ngay2, string id_room)
        {
            var product = context.RoomViewForCartModels.Where(x => x.Id_Room == id_room).FirstOrDefault();
            var cart = (Cart)Session["CartSession"];
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                Session["ngayden"] = DateTime.Parse(Request["ngay1"]);
                Session["ngaydi"]  = DateTime.Parse(Request["ngay2"]);
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
                return RedirectToAction("Index", "Cart");
            }
           
        }

        public List<ServiceViewModel> ListService()
        {
            var model = from services in context.Services

                        join service_type in context.ServiceTypes on services.ID_Type equals service_type.ID_Type
                        select new ServiceViewModel()
                        {
                            name_type = service_type.Name,
                            content_Service = service_type.Content_Service,
                            name = services.Name, 
                            image_services = services.Image_service,
                            id_services=services.Id_Service
                        };
            return model.ToList();
        }
        public ActionResult previews(string id)
        {

            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                ViewBag.Rooms = new homeController().ListRoom();
                var model = context.Phongviews.Find(id);
                //var model = context.Phongviews.Where(x=>x.Id_Room == id).ToList();

                return View(model);
            }
        }
        public ActionResult Search()
        {

            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                var model = new MyDbContext().SearchViews.Where(X => X.Adult_Amount != null);

                return View(model);
            }
        }
        //public ActionResult User()
        //{
        //    ViewBag.Rooms = new homeController().ListRoom();

        //    return View();
        //}
        //public ActionResult Index()
        //{
            
        //        ViewBag.banners = new homeController().ListBanner();
        //        ViewBag.Rooms = new homeController().ListRoom();
        //        ViewBag.Promotions = new homeController().ListPromotion();
        //        return View();
            
        //}
        public ActionResult Index()
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                int id = (int)Session["usernameid"];
                //  var donDatHang = db.Bookings.Where(x => x.Id_Customer == id && x.Status == false ).FirstOrDefault();
                ViewBag.banners = new homeController().ListBanner();
                ViewBag.Rooms = new homeController().ListRoom();
                ViewBag.Promotions = new homeController().ListPromotion();

                return View();
            }
        }

        public ActionResult DichVu()
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                ViewBag.Rooms = new homeController().ListRoom();
                ViewBag.Service = new homeController().ListService();

                return View();
            }
        }

        public ActionResult servicepr(string id)
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                ViewBag.Service = new homeController().ListService();
                var model = context.ServiceViews.Find(id);

                return View(model);
            }
        }

        //public ActionResult hoboi()
        //{
        //    var model = new MyDbContext().ImageServices.Where(X => X.Id_Service !=null);

        //    return View(model);
        //}
        
        //public ActionResult spa()
        //{
        //    var model = new MyDbContext().ImageServices.Where(X => X.Id_Service == "MDV01");

        //    return View(model);
        //}

        //public ActionResult gym()
        //{
        //    var model = new MyDbContext().ImageServices.Where(X => X.Id_Service == "MDV02").ToList();

        //    return View(model);
        //}
        //---------------------------------------------
        public ActionResult KhuyenMai()
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                ViewBag.promotions = new homeController().ListPromotion();
                return View();
            }
        }

        public ActionResult Contact()
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                ViewBag.Id_User = Session["usernameid"];
                return View();
            }
        }

        [HttpPost]
        public ActionResult Contact(Contact model)
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                context.Contacts.Add(model);
                context.SaveChanges();
                return RedirectToAction("index");
            }
        }
        //-----------------------
        /*
         
         */
        public ActionResult LoaiPhong()
        {

            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                ViewBag.Rooms = new homeController().ListRoom();
                return View();
            }
        }
        public ActionResult DatPhong()
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {

                if (Session["username"] == null)
                    return RedirectToAction("/Login", "home");
                else
                    return View();
            }
        }

        public ActionResult GioiThieu()
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                ViewBag.Introduces = new homeController().ListIntro();

                return View();
            }
        }

        public ActionResult Gallery()
        {
            if (Session["username"] == null)
                return RedirectToAction("/Login", "home");
            else
            {
                ViewBag.Gallerys = new homeController().ListGall();
                return View();
            }
        }
        //===============================================================
        //Loin
        public ActionResult Login()
        {
            return View();
        }
        //public ActionResult LoginUser(LoginModel model)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var dao = new UserDao();
        //        var result = dao.Login(model.UserName, model.Password);
        //        if (result)
        //        {
        //            var user = dao.GetID(model.UserName);
        //            var session = new SessionLogin();
        //            session.UserName = user.UserName;
        //            session.UserID = user.Id_User;
        //            Session.Add(UserSession.SessionU, session);

        //            return RedirectToAction("Index", "home");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Tên tài khoản hoặc mật khẩu không chính xác");
        //        }
        //    }
        //    return View("Login");
        //}
        public ActionResult LoginUser()
        {
            string us = Request.Form["us"];
            string mk = Request.Form["mk"];
            List<User> lstUser = getlstUser();
            User u = lstUser.Find(x => x.UserName.Equals(us));
            
            if (u != null)
            {
               if(u.PassWord.Equals(mk) && u.Permission == true) return View(@"~\Areas\Admin\Views\homeAdmin\Index.cshtml");//D:\SendSon\HotelBooking\HotelBooking\Areas\Admin\Views\homeAdmin\Index.cshtml
               else
                   if (u.PassWord.Equals(mk) && u.Permission == false)
                {
                    Session["usernameid"] = u.Id_User;
                    Session["username"] = us;
                    Session["user"] = (User)u;


                    TempData["msg"] = "Đăng nhập thành công nhé!";
                    return RedirectToAction("Index", "Home");
                    
                }
                else
                {
                    ModelState.AddModelError("", "Mật khẩu không chính xác");
                    //return RedirectToAction("Index");
                    return View("Login");
                }
            }
            else
            {
                ModelState.AddModelError("", "Tên tài khoản không chính xác");
                //return RedirectToAction("Index");
                return View("Login");
            }
        }

        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(User taiKhoan)
        {
            //if(ModelState.IsValid)
            //{
            //    var dao = new UserDao();
            //    var id = dao.Insert(taiKhoan);
            //    if(id != null )
            //    {
            //        return RedirectToAction("Login", "Home");
            //    }    
            //} 
            //else
            //{
            //    ModelState.AddModelError("", "Thất Bại hãy đăng ký lại !!");
            //}    
         
            //return View("Login");
            if (ModelState.IsValid)
            {
                context.Users.Add(taiKhoan);
                context.SaveChanges();
                return RedirectToAction("Login", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Thất Bại hãy đăng ký lại !!");
            }

            return View("Login");
        }

        //========================== Chi tiết phòng
        public ActionResult Luxury()
        {
            return View();
        }
     
        public ActionResult deluxe()
        {
            return View();
        }
        public ActionResult Superior()
        {
            return View();
        }
        public ActionResult Suite()
        {
            return View();
        }


        //
        // GET: /home/Details/5
        //==============================================================
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /home/Create

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
        // GET: /home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /home/Edit/5

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
        // GET: /home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /home/Delete/5

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
