namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSp")]
    public partial class LoaiSp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiSp()
        {
            tb_Sanpham = new HashSet<tb_Sanpham>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Tenloai { get; set; }

        [Required]
        [StringLength(250)]
        public string Icon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Sanpham> tb_Sanpham { get; set; }
    }
}
