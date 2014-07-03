namespace Mars.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RabotilniciDoktori")]
    public partial class RabotilniciDoktori
    {
        [Key]
        public int RabotilnicaDoktorId { get; set; }

        public int RabotilnicaId { get; set; }

        [Required]
        [StringLength(6)]
        public string DoktorFaksimil { get; set; }

        public double UplataIznos { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UplataDatum { get; set; }

        public DateTime VremePrijava { get; set; }

        public bool Prisuten { get; set; }

        public virtual Doktori Doktori { get; set; }

        public virtual Rabotilnici Rabotilnici { get; set; }
    }
}
