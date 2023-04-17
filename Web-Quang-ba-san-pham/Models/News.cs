namespace Web_Quang_ba_san_pham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewsID { get; set; }

        [Required]
        [StringLength(400)]
        public string title { get; set; }

        [Required]
        public string content { get; set; }

        [Required]
        [StringLength(255)]
        public string images { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }
    }
}
