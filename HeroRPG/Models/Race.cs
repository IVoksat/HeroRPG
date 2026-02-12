using System.ComponentModel.DataAnnotations;

namespace HeroRPG.Models
{
    using static Common.EntityValidationParams.HeroRaceValidation;
    public class Race
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(RaceNameMaxLength)]
        public string Name { get; set; } = null!;
        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int ConstitutionModifier { get; set; }

        public virtual ICollection<Hero> Heros { get; set; } = new HashSet<Hero>();

    }
}
