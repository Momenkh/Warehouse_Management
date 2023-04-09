namespace Warehouse_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.CompilerServices;

    public partial class Suppliers_Product
    {
        [Key]
        [StringLength(10)]
        public string Entry_Permit { get; set; }

        [Required]
        [StringLength(50)]
        public string Supplier_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string WH_Name { get; set; }

        [StringLength(10)]
        public string Product_Code_entry { get; set; }




        public int? Quantity { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }  
        
        public DateTime prod_date { get; set; }
        public DateTime exp_date { get; set; }
        public DateTime issue_date { get; set; }
    }
}
