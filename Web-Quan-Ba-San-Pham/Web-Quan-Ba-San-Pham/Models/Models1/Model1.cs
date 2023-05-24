using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Web_Quan_Ba_San_Pham.Models.Models1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<LoaiSp> LoaiSps { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tb_Anhsp> tb_Anhsp { get; set; }
        public virtual DbSet<tb_Baiviet> tb_Baiviet { get; set; }
        public virtual DbSet<tb_CTHD> tb_CTHD { get; set; }
        public virtual DbSet<tb_Hoadon> tb_Hoadon { get; set; }
        public virtual DbSet<tb_Lienhe> tb_Lienhe { get; set; }
        public virtual DbSet<tb_QC> tb_QC { get; set; }
        public virtual DbSet<tb_Sanpham> tb_Sanpham { get; set; }
        public virtual DbSet<tb_Theloai> tb_Theloai { get; set; }
        public virtual DbSet<tb_Theodoi> tb_Theodoi { get; set; }
        public virtual DbSet<tb_ThongKe> tb_ThongKe { get; set; }
        public virtual DbSet<tb_Tintuc> tb_Tintuc { get; set; }
        public virtual DbSet<tb_Tuychonhethong> tb_Tuychonhethong { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSp>()
                .HasMany(e => e.tb_Sanpham)
                .WithRequired(e => e.LoaiSp)
                .HasForeignKey(e => e.IdLoaisp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Hoadon>()
                .HasMany(e => e.tb_CTHD)
                .WithRequired(e => e.tb_Hoadon)
                .HasForeignKey(e => e.IdHoadon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Sanpham>()
                .HasMany(e => e.tb_Anhsp)
                .WithRequired(e => e.tb_Sanpham)
                .HasForeignKey(e => e.IdSanpham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Sanpham>()
                .HasMany(e => e.tb_CTHD)
                .WithRequired(e => e.tb_Sanpham)
                .HasForeignKey(e => e.IdSanpham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Theloai>()
                .HasMany(e => e.tb_Baiviet)
                .WithRequired(e => e.tb_Theloai)
                .HasForeignKey(e => e.IdTheloai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Theloai>()
                .HasMany(e => e.tb_Tintuc)
                .WithRequired(e => e.tb_Theloai)
                .HasForeignKey(e => e.IdTheloai)
                .WillCascadeOnDelete(false);
        }
    }
}
