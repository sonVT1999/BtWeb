using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Common
{
    [Serializable]
    public class SessionLogin
    {
        public long UserID { set; get; }
        public string UserName { set; get; }
        public bool? quyen { get; set; }
    }
}