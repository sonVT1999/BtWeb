namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gallery")]
    public partial class Gallery
    {
        [Key]
        [StringLength(8)]
        public string Id_Glr { get; set; }

        [StringLength(200)]
        public string ImageLink { get; set; }

        public bool? Active { get; set; }
    }
}
