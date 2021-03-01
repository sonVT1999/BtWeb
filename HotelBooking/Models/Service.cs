namespace HotelBooking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            ImageServices = new HashSet<ImageService>();
        }

        [Key]
        [StringLength(8)]
        public string Id_Service { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public bool? Active { get; set; }

        [StringLength(8)]
        public string ID_Type { get; set; }

        [StringLength(200)]
        public string Image_service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageService> ImageServices { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
