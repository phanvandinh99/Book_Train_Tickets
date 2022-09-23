namespace BookTrainTicketsWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichTrinh")]
    public partial class LichTrinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichTrinh()
        {
            VeTau = new HashSet<VeTau>();
        }

        [Key]
        public int MaLichTrinh { get; set; }

        public DateTime NgayDi { get; set; }

        [Required]
        [StringLength(100)]
        public string GaDen { get; set; }

        public DateTime NgayDuKienDen { get; set; }

        public int? MaTau { get; set; }

        public int? MaNhaGa { get; set; }

        public virtual NhaGa NhaGa { get; set; }

        public virtual Tau Tau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeTau> VeTau { get; set; }
    }
}
