using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HeroRPG.Models
{
    using static Common.EntityValidationParams.HeroValidationParams;

    public class Hero
    {
        [Key]
        public int Id { get; set; }
        [Required]
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

        [Required]
        public int RaceID { get; set; }

        [ForeignKey(nameof(RaceID))]
        public virtual Race Race { get; set; } = null!;
        public bool IsDeleted { get; set; } = false;
        public bool IsPublic { get; set; } = true;
    }
}
