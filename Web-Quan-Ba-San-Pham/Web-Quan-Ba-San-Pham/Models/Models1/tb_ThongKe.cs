namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_ThongKe
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public long SoTruyCap { get; set; }
    }
}
