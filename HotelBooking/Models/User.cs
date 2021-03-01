namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Bookings = new HashSet<Booking>();
            Contacts = new HashSet<Contact>();
        }

        [Key]
        public int Id_User { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string PassWord { get; set; }

        public bool? Sex { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Address { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        public bool? Status { get; set; }

        public bool? Permission { get; set; }

        [StringLength(200)]
        public string ImageLink { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
