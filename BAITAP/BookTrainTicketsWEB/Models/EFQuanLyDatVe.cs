using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookTrainTicketsWEB.Models
{
    public partial class EFQuanLyDatVe : DbContext
    {
        public EFQuanLyDatVe()
            : base("name=EFQuanLyDatVe")
        {
        }

        public virtual DbSet<CTPhieuDatVe> CTPhieuDatVe { get; set; }
        public virtual DbSet<KieuGhe> KieuGhe { get; set; }
        public virtual DbSet<LichTrinh> LichTrinh { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<NhaGa> NhaGa { get; set; }
        public virtual DbSet<PhieuDatVe> PhieuDatVe { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<Tau> Tau { get; set; }
        public virtual DbSet<Toa> Toa { get; set; }
        public virtual DbSet<VeTau> VeTau { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatVe>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatVe>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);
        }
    }
}
