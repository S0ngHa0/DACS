namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Tuychonhethong
    {
        [Key]
        [StringLength(50)]
        public string IdCaidat { get; set; }

        [StringLength(4000)]
        public string CaidatGiatri { get; set; }

        [StringLength(4000)]
        public string CaidatMota { get; set; }
    }
}
