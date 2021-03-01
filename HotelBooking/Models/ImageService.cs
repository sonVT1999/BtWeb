namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageService")]
    public partial class ImageService
    {
        [Key]
        [StringLength(8)]
        public string Id_image { get; set; }

        [StringLength(200)]
        public string imageLink { get; set; }

        [StringLength(8)]
        public string Id_Service { get; set; }

        public virtual Service Service { get; set; }
    }
}
