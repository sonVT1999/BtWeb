namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomViewForCartModel")]
    public partial class RoomViewForCartModel
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Id_Room { get; set; }

        public double? Price { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(200)]
        public string imageLink { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Id_image { get; set; }
    }
}
