namespace Warehouse_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            WH_ProductsList = new HashSet<WH_ProductsList>();
        }

        [Key]
        [StringLength(10)]
        public string Product_Code { get; set; }

        [StringLength(50)]
        public string Product_Name { get; set; }

        [StringLength(50)]
        public string Product_Units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WH_ProductsList> WH_ProductsList { get; set; }
    }
}
