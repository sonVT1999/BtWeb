namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Introduce")]
    public partial class Introduce
    {
        [StringLength(8)]
        public string Id { get; set; }

        [StringLength(200)]
        public string imageLink { get; set; }

        public string note1 { get; set; }

        public string note2 { get; set; }

        public string note3 { get; set; }

        public string note4 { get; set; }

        public string note5 { get; set; }
    }
}
