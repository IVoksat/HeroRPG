
using System.ComponentModel.DataAnnotations;

namespace HeroRPG.ViewModels
{
    public class SelectRaceViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
