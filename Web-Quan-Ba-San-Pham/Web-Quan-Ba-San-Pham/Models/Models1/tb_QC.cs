namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_QC
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Tieude { get; set; }

        [Required]
        [StringLength(500)]
        public string Mota { get; set; }

        [StringLength(500)]
        public string Hinhanh { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        public int Type { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaysua { get; set; }
    }
}
