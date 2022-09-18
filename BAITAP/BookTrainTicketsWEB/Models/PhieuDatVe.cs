namespace BookTrainTicketsWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDatVe")]
    public partial class PhieuDatVe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuDatVe()
        {
            CTPhieuDatVe = new HashSet<CTPhieuDatVe>();
        }

        [Key]
        public int MaPhieuDatve { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string CCCD { get; set; }

        public DateTime? NgayDat { get; set; }

        public int? HinhThucThanhToan { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(100)]
        public string GaDi { get; set; }

        [StringLength(100)]
        public string GaDen { get; set; }

        public double? TongTien { get; set; }

        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuDatVe> CTPhieuDatVe { get; set; }
    }
}
