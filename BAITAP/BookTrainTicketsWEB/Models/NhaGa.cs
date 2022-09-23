namespace BookTrainTicketsWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaGa")]
    public partial class NhaGa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaGa()
        {
            LichTrinh = new HashSet<LichTrinh>();
        }

        [Key]
        public int MaNhaGa { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNhaGa { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichTrinh> LichTrinh { get; set; }
    }
}
