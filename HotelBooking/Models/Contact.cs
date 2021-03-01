namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [Key]
        public int Id_Contact { get; set; }

        public string Content { get; set; }

        public int? Id_Customer { get; set; }

        public virtual User User { get; set; }
    }
}
