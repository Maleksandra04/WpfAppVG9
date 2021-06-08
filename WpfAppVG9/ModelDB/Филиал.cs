namespace WpfAppVG9.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Филиал
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Филиал()
        {
            Компания = new HashSet<Компания>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IDfilial { get; set; }

        [StringLength(20)]
        public string Filial { get; set; }

        [StringLength(10)]
        public string InnFilial { get; set; }

        [StringLength(60)]
        public string Chief { get; set; }

        public int? Capacity { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Компания> Компания { get; set; }
    }
}
