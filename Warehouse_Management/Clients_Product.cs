namespace Warehouse_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients_Product
    {
        [Key]
        [StringLength(10)]
        public string Exit_Permit { get; set; }

        [Required]
        [StringLength(50)]
        public string Client_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string WH_Name { get; set; }

        [StringLength(10)]
        public string Product_Code_exit { get; set; }

        public int? Quantity { get; set; }

        public virtual Client Client { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public DateTime prod_date { get; set; }
        public DateTime exp_date { get; set; }
        public DateTime issue_date { get; set; }
    }
}
