namespace Warehouse_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Suppliers_Product = new HashSet<Suppliers_Product>();
        }

        [Key]
        [StringLength(50)]
        public string Supplier_Name { get; set; }

        [StringLength(10)]
        public string Supplier_tele { get; set; }

        [Required]
        [StringLength(15)]
        public string Supplier_mob { get; set; }

        [StringLength(10)]
        public string Supplier_fax { get; set; }

        [StringLength(50)]
        public string Supplier_email { get; set; }

        [StringLength(50)]
        public string Supplier_website { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suppliers_Product> Suppliers_Product { get; set; }
    }
}
