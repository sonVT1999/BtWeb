namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NotePreview
    {
        [StringLength(30)]
        public string Id { get; set; }

        public string Note1 { get; set; }

        public string Note2 { get; set; }

        [StringLength(8)]
        public string Id_Type { get; set; }

        public string Note3 { get; set; }

        public string Note4 { get; set; }

        public string Note5 { get; set; }

        public string Note6 { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
