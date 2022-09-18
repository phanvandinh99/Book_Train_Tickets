namespace BookTrainTicketsWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuDatVe")]
    public partial class CTPhieuDatVe
    {
        [Key]
        public int MaCTPhieuDatVe { get; set; }

        public int? DoiTuong { get; set; }

        public double? ThanhTien { get; set; }

        public int? MaVeTau { get; set; }

        public int? MaPhieuDatve { get; set; }

        public virtual PhieuDatVe PhieuDatVe { get; set; }

        public virtual VeTau VeTau { get; set; }
    }
}
