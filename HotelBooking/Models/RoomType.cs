namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomType")]
    public partial class RoomType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomType()
        {
            NotePreviews = new HashSet<NotePreview>();
            Rooms = new HashSet<Room>();
        }

        [Key]
        [StringLength(8)]
        public string Id_Type { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(1)]
        public string Bed_Amount { get; set; }

        public byte? Size { get; set; }

        [StringLength(1)]
        public string Adult_Amount { get; set; }

        [StringLength(1)]
        public string Children_Amount { get; set; }

        public bool? Active { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotePreview> NotePreviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
