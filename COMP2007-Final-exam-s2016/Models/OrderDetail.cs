namespace COMP2007_Final_exam_s2016.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int AlbumId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Album Album { get; set; }

        public virtual Order Order { get; set; }
    }
}
