namespace BookTrainTicketsWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VeTau")]
    public partial class VeTau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VeTau()
        {
            CTPhieuDatVe = new HashSet<CTPhieuDatVe>();
        }

        [Key]
        public int MaVeTau { get; set; }

        [StringLength(50)]
        public string TenVeTau { get; set; }

        public double GiaVe { get; set; }

        public int? TrangThai { get; set; }

        public int? MaKieuGhe { get; set; }

        public int? MaNhaGa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuDatVe> CTPhieuDatVe { get; set; }

        public virtual KieuGhe KieuGhe { get; set; }

        public virtual NhaGa NhaGa { get; set; }
    }
}
