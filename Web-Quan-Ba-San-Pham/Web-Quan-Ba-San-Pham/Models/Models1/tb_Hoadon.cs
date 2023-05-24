namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Hoadon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Hoadon()
        {
            tb_CTHD = new HashSet<tb_CTHD>();
        }

        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string TenKH { get; set; }

        [Required]
        public string Sdt { get; set; }

        [Required]
        public string Diachi { get; set; }

        public decimal TotalAmount { get; set; }

        public int Soluong { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaysua { get; set; }

        public int Kieuthanhtoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CTHD> tb_CTHD { get; set; }
    }
}
