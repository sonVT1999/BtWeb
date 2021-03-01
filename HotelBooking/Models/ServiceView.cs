namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceView")]
    public partial class ServiceView
    {
        [Key]
        [StringLength(8)]
        public string Id_Service { get; set; }

        [StringLength(200)]
        public string Image_service { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public string Content_Service { get; set; }

        [StringLength(30)]
        public string Nametype { get; set; }
    }
}
