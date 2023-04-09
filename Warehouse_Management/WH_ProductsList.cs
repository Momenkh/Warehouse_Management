namespace Warehouse_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WH_ProductsList
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Product_Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string WH_Name { get; set; }

        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
