namespace Warehouse_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Clients_Product = new HashSet<Clients_Product>();
        }

        [Key]
        [StringLength(50)]
        public string Client_Name { get; set; }

        [StringLength(10)]
        public string Client_tele { get; set; }

        [Required]
        [StringLength(15)]
        public string Client_mob { get; set; }

        [StringLength(10)]
        public string Client_fax { get; set; }

        [StringLength(50)]
        public string Client_email { get; set; }

        [StringLength(50)]
        public string Client_website { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clients_Product> Clients_Product { get; set; }
    }
}
