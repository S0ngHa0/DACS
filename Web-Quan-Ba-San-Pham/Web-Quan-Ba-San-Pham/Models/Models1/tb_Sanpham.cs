namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Sanpham()
        {
            tb_Anhsp = new HashSet<tb_Anhsp>();
            tb_CTHD = new HashSet<tb_CTHD>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Tieude { get; set; }

        [StringLength(50)]
        public string Masanpham { get; set; }

        public string Mota { get; set; }

        [StringLength(250)]
        public string Hinhanh { get; set; }

        public decimal Gia { get; set; }

        public decimal? Giamgia { get; set; }

        public int Soluong { get; set; }

        public bool Sp { get; set; }

        public bool SpSale { get; set; }

        public bool SpTuonglai { get; set; }

        public bool SpHot { get; set; }

        public int IdLoaisp { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaysua { get; set; }

        public bool Trangthai { get; set; }

        public int Luotxem { get; set; }

        public decimal Giagoc { get; set; }

        public virtual LoaiSp LoaiSp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Anhsp> tb_Anhsp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CTHD> tb_CTHD { get; set; }
    }
}
