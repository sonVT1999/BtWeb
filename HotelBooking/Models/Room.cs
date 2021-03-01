namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            BookingDetails = new HashSet<BookingDetail>();
            ImageRooms = new HashSet<ImageRoom>();
        }

        [Key]
        [StringLength(8)]
        public string Id_Room { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public double? Price { get; set; }

        public bool? Status { get; set; }

        public bool? Active { get; set; }

        [StringLength(8)]
        public string Id_Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageRoom> ImageRooms { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
