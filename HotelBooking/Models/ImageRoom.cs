namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageRoom")]
    public partial class ImageRoom
    {
        [Key]
        [StringLength(8)]
        public string Id_image { get; set; }

        [StringLength(200)]
        public string imageLink { get; set; }

        [StringLength(8)]
        public string Id_Room { get; set; }

        [StringLength(20)]
        public string Slide1 { get; set; }

        [StringLength(20)]
        public string Slide2 { get; set; }

        [StringLength(20)]
        public string Slide3 { get; set; }

        [StringLength(20)]
        public string Slide4 { get; set; }

        [StringLength(20)]
        public string Slide5 { get; set; }

        [StringLength(20)]
        public string Slide6 { get; set; }

        public virtual Room Room { get; set; }
    }
}
