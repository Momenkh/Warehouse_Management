namespace Warehouse_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            Clients_Product = new HashSet<Clients_Product>();
            Suppliers_Product = new HashSet<Suppliers_Product>();
            WH_ProductsList = new HashSet<WH_ProductsList>();
        }

        [Key]
        [StringLength(50)]
        public string WH_Name { get; set; }

        [Required]
        [StringLength(150)]
        public string WH_Address { get; set; }

        [StringLength(50)]
        public string WH_Manager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clients_Product> Clients_Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suppliers_Product> Suppliers_Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WH_ProductsList> WH_ProductsList { get; set; }
    }
}
