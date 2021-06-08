namespace WpfAppVG9.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Товар
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Товар()
        {
            Ремонт = new HashSet<Ремонт>();
        }

        [Key]
        [StringLength(15)]
        public string GoodsID { get; set; }

        [StringLength(40)]
        public string Goods { get; set; }

        [StringLength(20)]
        public string Categoty { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [StringLength(40)]
        public string Company { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [StringLength(10)]
        public string INNcompany { get; set; }

        [StringLength(60)]
        public string AddressComp { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStart { get; set; }

        public int? Period { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBuy { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ремонт> Ремонт { get; set; }
    }
}
