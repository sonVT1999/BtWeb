namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Promotion")]
    public partial class Promotion
    {
        [Key]
        [StringLength(8)]
        public string Id_Prom { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageLink { get; set; }

        public bool? Active { get; set; }

        [StringLength(300)]
        public string Detail { get; set; }
    }
}
