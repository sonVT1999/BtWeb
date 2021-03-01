namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("banner")]
    public partial class banner
    {
        [Key]
        [StringLength(8)]
        public string Id_banner { get; set; }

        [StringLength(200)]
        public string imageLink { get; set; }
    }
}
