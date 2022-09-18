namespace BookTrainTicketsWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KieuGhe")]
    public partial class KieuGhe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KieuGhe()
        {
            VeTau = new HashSet<VeTau>();
        }

        [Key]
        public int MaKieuGhe { get; set; }

        [StringLength(100)]
        public string TenKieuGhe { get; set; }

        public int ViTriGhe { get; set; }

        public int? LePhi { get; set; }

        public int? TrangThai { get; set; }

        public int? MaToa { get; set; }

        public virtual Toa Toa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeTau> VeTau { get; set; }
    }
}
