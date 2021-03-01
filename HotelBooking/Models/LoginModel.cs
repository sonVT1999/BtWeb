using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Chưa Nhập UserName")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Chưa Nhập Password")]
        public string Password { set; get; }

        public bool RememberMe {set;get;}
    }
}