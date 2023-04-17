namespace Web_Quang_ba_san_pham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReturnPolicy")]
    public partial class ReturnPolicy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PolicyID { get; set; }

        public int ReturnTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Method { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
