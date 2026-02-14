using System.ComponentModel.DataAnnotations;

namespace HeroRPG.ViewModels
{
    using static Common.EntityValidationParams.HeroRaceValidation;
    using static Common.EntityValidationParams.HeroValidationParams;
    public class CreateNewHeroForm
    {
        public int Id { get; set; }
        [MaxLength(HeroNameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        public int Strength { get; set; }
        [Required]
        public int Constitution { get; set; }
        [Required]
        public int Dexterity { get; set; }
        [MaxLength(HeroDescriptionMaxLength)]
        public string? Description { get; set; }
        [MaxLength(RaceNameMaxLength)]
        [MinLength(RaceNameMinLength)]
        public IEnumerable<SelectRaceViewModel> RaceName { get; set; } = null!;
    }
}
