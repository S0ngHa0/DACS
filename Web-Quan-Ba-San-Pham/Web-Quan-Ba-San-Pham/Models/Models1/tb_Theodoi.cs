namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Theodoi
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }
    }
}
