using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.ViewModels
{
    public class RoomViewModel
    {
        public string nameType { get; set; }
        public string imageLink { get; set; }
        public double? price { get; set; }
        public string bedAmount { get; set; }
        public string adultAmount { get; set; }
        public string childAmount { get; set; }
        public int? size { get; set; }
        public string url { get; set;  }
        public string MASP { get; set; }
    }
}