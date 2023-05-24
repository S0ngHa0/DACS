namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Theloai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Theloai()
        {
            tb_Baiviet = new HashSet<tb_Baiviet>();
            tb_Tintuc = new HashSet<tb_Tintuc>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Tieude { get; set; }

        public string Mota { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaysua { get; set; }

        public string Link { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Baiviet> tb_Baiviet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Tintuc> tb_Tintuc { get; set; }
    }
}
