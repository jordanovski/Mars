namespace Mars.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gradovi")]
    public partial class Gradovi
    {
        public Gradovi()
        {
            Doktori = new HashSet<Doktori>();
            Prezenteri = new HashSet<Prezenteri>();
            Rabotilnici = new HashSet<Rabotilnici>();
        }

        [Key]
        public int GradId { get; set; }

        [Required]
        [StringLength(50)]
        public string GradIme { get; set; }

        public virtual ICollection<Doktori> Doktori { get; set; }

        public virtual ICollection<Prezenteri> Prezenteri { get; set; }

        public virtual ICollection<Rabotilnici> Rabotilnici { get; set; }
    }
}
