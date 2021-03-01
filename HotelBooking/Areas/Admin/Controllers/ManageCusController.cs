using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBooking.Models;
using System.Data.SqlClient;
using HotelBooking.ViewModels;

namespace HotelBooking.Areas.Admin.Controllers
{
    public class ManageCusController : Controller
    {
        private MyDbContext context = new MyDbContext();
        //
        // GET: /Admin/ManageCus/
        public ActionResult Index()
        {
            //var model = new MyDbContext().Users.SqlQuery("getAllCus");
            var model = context.Users.Where(x => x.Id_User != null).ToList();
            //var model = context.Database.SqlQuery<User>("select * from User").ToList();
            return View(model);
        }

        //
        // GET: /Admin/ManageCus/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //Search Cus follow id
        [HttpPost]
        public ActionResult SearchCus(string nameCus)
        {
            List<User> model = new List<User>();
            if (nameCus == "")
            {
                model = context.Users.Where(x => x.Id_User != null).ToList();
            }
            else 
            {
                model = context.Users.Where(x => x.Name == nameCus).ToList();
            }
            
            return View("Index", model);
        }

        //
        // GET: /Admin/ManageCus/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/ManageCus/Create

        [HttpPost]
        public ActionResult CreatCus(User model)
        {
            try
            {
                //SqlParameter[] idParam ={
                //                        new SqlParameter {ParameterName = "Id_User", Value = model.Id_User }, 
                //                        new SqlParameter{ParameterName = "Name", Value = model.Name },
                //                        new SqlParameter{ParameterName = "Sex", Value = model.Sex },
                //                        new SqlParameter{ParameterName = "Email", Value = model.Email },
                //                        new SqlParameter{ParameterName = "Address", Value = model.Address },
                //                        new SqlParameter{ParameterName = "Phone", Value = model.Phone },
                //                        new SqlParameter{ParameterName = "Permission", Value = model.Permission },
                //                        new SqlParameter{ParameterName = "ImageLink", Value = model.ImageLink }
                //                        };

                //var dbContext = new MyDbContext();
                //dbContext.Database.ExecuteSqlCommand("creatCus @Id_User, @Name, @Sex, @Email, @Address, @Phone, @Permission, @ImageLink ", idParam);
                //dbContext.SaveChanges();
                context.Users.Add(model);
                context.SaveChanges();
                return RedirectToAction ("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageCus/Edit/5

        public ActionResult Edit(string id)
        {
            var model = context.Users.Find(int.Parse(id));
            return View(model);
        }

        //
        // POST: /Admin/ManageCus/Edit/5

        [HttpPost]
        public ActionResult Edit(User model)
        {
            try
            {
                // TODO: Add update logic here
                var obj = context.Users.Find(model.Id_User);
                obj.Id_User = model.Id_User;
                obj.Name = model.Name;
                obj.Permission = model.Permission;
                obj.Sex = model.Sex;
                obj.Email = model.Email;
                obj.Address = model.Address;
                obj.Phone = model.Phone;
                obj.ImageLink = model.ImageLink;

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/ManageCus/Delete/5

        public ActionResult Delete(int id)
        {
            var model = context.Users.Find(id);
            return View("Edit",model);
        }

        //
        // POST: /Admin/ManageCus/Delete/5

        [HttpPost]
        public ActionResult Delete(User model)
        {
            try
            {
                // TODO: Add delete logic here
                var obj = context.Users.Find(model.Id_User);
                context.Users.Remove(obj);
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
