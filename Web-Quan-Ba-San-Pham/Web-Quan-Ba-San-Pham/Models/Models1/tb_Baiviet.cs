namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Baiviet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Tieude { get; set; }

        public string Mota { get; set; }

        public string Chitiet { get; set; }

        [StringLength(250)]
        public string Hinhanh { get; set; }

        public int IdTheloai { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaysua { get; set; }

        public bool Trangthai { get; set; }

        public virtual tb_Theloai tb_Theloai { get; set; }
    }
}
