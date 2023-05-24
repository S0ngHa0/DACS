namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_CTHD
    {
        public int Id { get; set; }

        public int IdHoadon { get; set; }

        public int IdSanpham { get; set; }

        public decimal Gia { get; set; }

        public int Soluong { get; set; }

        public virtual tb_Hoadon tb_Hoadon { get; set; }

        public virtual tb_Sanpham tb_Sanpham { get; set; }
    }
}
