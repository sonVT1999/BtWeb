namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phongview")]
    public partial class Phongview
    {
        [StringLength(30)]
        public string Name { get; set; }

        [Key]
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

        public string Note1 { get; set; }

        public string Note2 { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public string Note3 { get; set; }

        public string Note4 { get; set; }

        public string Note5 { get; set; }

        public string Note6 { get; set; }
    }
}
