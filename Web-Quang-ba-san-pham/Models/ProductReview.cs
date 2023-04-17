namespace Web_Quang_ba_san_pham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductReview")]
    public partial class ProductReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReviewID { get; set; }

        public int ProductID { get; set; }

        public int CustomerID { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        public int Rating { get; set; }

        public DateTime ReviewDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
