namespace Mars.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doktori")]
    public partial class Doktori
    {
        public Doktori()
        {
            RabotilniciDoktori = new HashSet<RabotilniciDoktori>();
        }

        [Key]
        [StringLength(6)]
        public string DoktorFaksimil { get; set; }

        [Required]
        [StringLength(50)]
        public string DoktorImePrezime { get; set; }

        public int? GradId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string FixedPhone { get; set; }

        public virtual Gradovi Gradovi { get; set; }

        public virtual ICollection<RabotilniciDoktori> RabotilniciDoktori { get; set; }
    }
}
