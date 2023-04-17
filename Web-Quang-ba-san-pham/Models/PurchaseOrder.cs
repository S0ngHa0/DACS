namespace Web_Quang_ba_san_pham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseOrder")]
    public partial class PurchaseOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillID { get; set; }

        public int SupplierID { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalMoney { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
