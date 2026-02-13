using System.ComponentModel.DataAnnotations;

namespace HeroRPG.ViewModels
{
    using static Common.EntityValidationParams.HeroRaceValidation;
    using static Common.EntityValidationParams.HeroValidationParams;
    public class HeroViewModel
    {
        public int Id { get; set; }
        [MaxLength(HeroNameMaxLength)]
        public string Name { get; set; } = null!;
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        [MaxLength(HeroDescriptionMaxLength)]
        public string? Description { get; set; }
        [MaxLength(RaceNameMaxLength)]
        [MinLength(RaceNameMinLength)]
        public string RaceName { get; set; } = null!;
    }
}
