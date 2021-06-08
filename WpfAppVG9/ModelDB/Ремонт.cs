namespace WpfAppVG9.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ремонт
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDRepair { get; set; }

        [StringLength(12)]
        public string Fax { get; set; }

        public int? CustomerID { get; set; }

        [StringLength(15)]
        public string GoodsID { get; set; }

        [Column(TypeName = "money")]
        public decimal? CostRepair { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public int? Guarantee { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StopDate { get; set; }

        public virtual Компания Компания { get; set; }

        public virtual Покупатель Покупатель { get; set; }

        public virtual Товар Товар { get; set; }
    }
}
