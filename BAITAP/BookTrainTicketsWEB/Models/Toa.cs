namespace BookTrainTicketsWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Toa")]
    public partial class Toa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Toa()
        {
            KieuGhe = new HashSet<KieuGhe>();
        }

        [Key]
        public int MaToa { get; set; }

        [Required]
        [StringLength(100)]
        public string TenToa { get; set; }

        public int SoGhe { get; set; }

        public int? MaTau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KieuGhe> KieuGhe { get; set; }

        public virtual Tau Tau { get; set; }
    }
}
