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
        [Key]
        public int MaLichTrinh { get; set; }

        public DateTime NgayDi { get; set; }

        public int GaDen { get; set; }

        public DateTime NgayDuKienDen { get; set; }

        public int? MaTau { get; set; }

        public int? MaNhaGa { get; set; }

        public virtual NhaGa NhaGa { get; set; }

        public virtual Tau Tau { get; set; }
    }
}
