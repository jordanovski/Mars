namespace Mars.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RabotilniciPrezenteri")]
    public partial class RabotilniciPrezenteri
    {
        [Key]
        public int RabotilnicaPrezenterId { get; set; }

        public int RabotilnicaId { get; set; }

        [Required]
        [StringLength(6)]
        public string PrezenterFaksimil { get; set; }

        public virtual Prezenteri Prezenteri { get; set; }

        public virtual Rabotilnici Rabotilnici { get; set; }
    }
}
