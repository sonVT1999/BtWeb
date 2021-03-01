namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingDetail")]
    public partial class BookingDetail
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDay { get; set; }

        [StringLength(1)]
        public string Adult_Amount { get; set; }

        [StringLength(1)]
        public string Children_Amount { get; set; }

        public double? Total_Amount { get; set; }

        public bool? Status { get; set; }

        [StringLength(8)]
        public string Id_Room { get; set; }

        public int? Id_Booking { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Room Room { get; set; }
    }
}
