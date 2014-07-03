namespace Mars.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prezenteri")]
    public partial class Prezenteri
    {
        public Prezenteri()
        {
            RabotilniciPrezenteri = new HashSet<RabotilniciPrezenteri>();
        }

        [Key]
        [StringLength(6)]
        public string PrezenterFaksimil { get; set; }

        [Required]
        [StringLength(50)]
        public string PrezenterImePrezime { get; set; }

        public int? GradId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string FixedPhone { get; set; }

        public virtual Gradovi Gradovi { get; set; }

        public virtual ICollection<RabotilniciPrezenteri> RabotilniciPrezenteri { get; set; }
    }
}
