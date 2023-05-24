namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Lienhe
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Ten { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public string Website { get; set; }

        [StringLength(4000)]
        public string Tinnhan { get; set; }

        public bool Trangthai { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaysua { get; set; }
    }
}
