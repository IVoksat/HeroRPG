using HeroRPG.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HeroRPG.Data.Configurations
{
    public class RaceConfigurations : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.HasMany(r => r.Heros)
                   .WithOne(ra => ra.Race)
                   .HasForeignKey(ra => ra.RaceID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Race
                {
                    Id = 1,
                    Name = "Human",
                    StrengthModifier = 1,
                    DexterityModifier = 1,
                    ConstitutionModifier = 1
                },
                new Race
                {
                    Id = 2,
                    Name = "Elf",
                    StrengthModifier = 0,
                    DexterityModifier = 3,
                    ConstitutionModifier = -1
                },
                new Race
                {
                    Id = 3,
                    Name = "Dwarf",
                    StrengthModifier = 2,
                    DexterityModifier = -1,
                    ConstitutionModifier = 2
                },
                new Race
                {
                    Id = 4,
                    Name = "Orc",
                    StrengthModifier = 3,
                    DexterityModifier = -1,
                    ConstitutionModifier = 1
                },
                new Race
                {
                    Id = 5,
                    Name = "Halfling",
                    StrengthModifier = -1,
                    DexterityModifier = 4,
                    ConstitutionModifier = -1
                }
            );
        }
    }
}
