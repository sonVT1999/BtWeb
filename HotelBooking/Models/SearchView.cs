namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SearchView")]
    public partial class SearchView
    {
        public double? Price { get; set; }

        [Key]
        [StringLength(8)]
        public string Id_Room { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(1)]
        public string Adult_Amount { get; set; }

        [StringLength(1)]
        public string Bed_Amount { get; set; }

        [StringLength(1)]
        public string Children_Amount { get; set; }

        public byte? Size { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        [StringLength(200)]
        public string imageLink { get; set; }
    }
}
