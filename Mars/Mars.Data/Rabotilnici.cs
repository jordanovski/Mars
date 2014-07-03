namespace Mars.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rabotilnici")]
    public partial class Rabotilnici
    {
        public Rabotilnici()
        {
            RabotilniciDoktori = new HashSet<RabotilniciDoktori>();
            RabotilniciPrezenteri = new HashSet<RabotilniciPrezenteri>();
        }

        [Key]
        public int RabotilnicaId { get; set; }

        public int TemaId { get; set; }

        public int GradId { get; set; }

        [StringLength(50)]
        public string Mesto { get; set; }

        [Required]
        [StringLength(500)]
        public string Lokacija { get; set; }

        [Column(TypeName = "date")]
        public DateTime Datum { get; set; }

        public TimeSpan Pocetok { get; set; }

        public TimeSpan? Kraj { get; set; }

        public int? Bodovi { get; set; }

        public int? OptimumPosetiteli { get; set; }

        public virtual Gradovi Gradovi { get; set; }

        public virtual Temi Temi { get; set; }

        public virtual ICollection<RabotilniciDoktori> RabotilniciDoktori { get; set; }

        public virtual ICollection<RabotilniciPrezenteri> RabotilniciPrezenteri { get; set; }
    }
}
