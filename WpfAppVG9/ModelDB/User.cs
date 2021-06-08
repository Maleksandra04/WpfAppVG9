namespace WpfAppVG9.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [StringLength(20)]
        public string Users { get; set; }

        [StringLength(15)]
        public string Password { get; set; }
    }
}
