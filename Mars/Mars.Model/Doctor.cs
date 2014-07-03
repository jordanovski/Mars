using System.ComponentModel.DataAnnotations;

namespace Mars.Model
{
    public partial class Doctor
    {

        [Key]
        [StringLength(6)]
        public string Faksimil { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? CityId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string FixedPhone { get; set; }


        public virtual City Cities { get; set; }
    }
}
