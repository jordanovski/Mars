namespace Mars.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Temi")]
    public partial class Temi
    {
        public Temi()
        {
            Rabotilnici = new HashSet<Rabotilnici>();
        }

        [Key]
        public int TemaId { get; set; }

        [Required]
        public string TemaIme { get; set; }

        public string TemaOpis { get; set; }

        public virtual ICollection<Rabotilnici> Rabotilnici { get; set; }
    }
}
