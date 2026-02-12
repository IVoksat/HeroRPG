using HeroRPG.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HeroRPG.Data.Configurations
{
    public class HeroConfigurations : IEntityTypeConfiguration<Hero>
    {
        public void Configure(EntityTypeBuilder<Hero> builder)
        {
            builder.HasData(
                new Hero
                {
                    Id = 1,
                    Name = "Arlen Swift",
                    Strength = 10,
                    Constitution = 8,
                    Dexterity = 15,
                    Description = "A quick-footed scout.",
                    RaceID = 2
                },
                new Hero
                {
                    Id = 2,
                    Name = "Borin Stonehelm",
                    Strength = 16,
                    Constitution = 14,
                    Dexterity = 8,
                    Description = "Stout warrior and miner.",
                    RaceID = 3
                },
                new Hero
                {
                    Id = 3,
                    Name = "Thora Ironfist",
                    Strength = 18,
                    Constitution = 12,
                    Dexterity = 9,
                    Description = "Fearsome berserker.",
                    RaceID = 4
                },
                new Hero
                {
                    Id = 4,
                    Name = "Lysa Meadow",
                    Strength = 8,
                    Constitution = 10,
                    Dexterity = 16,
                    Description = "Clever trickster.",
                    RaceID = 5
                },
                new Hero
                {
                    Id = 5,
                    Name = "Sir Gareth",
                    Strength = 14,
                    Constitution = 13,
                    Dexterity = 12,
                    Description = "Knight of the realm.",
                    RaceID = 1
                },
                new Hero
                {
                    Id = 6,
                    Name = "Mira Greenleaf",
                    Strength = 9,
                    Constitution = 9,
                    Dexterity = 14,
                    Description = "Archer and herbalist.",
                    RaceID = 2
                },
                new Hero
                {
                    Id = 7,
                    Name = "Torik Broadshield",
                    Strength = 15,
                    Constitution = 15,
                    Dexterity = 9,
                    Description = "Defender of the halls.",
                    RaceID = 3
                },
                new Hero
                {
                    Id = 8,
                    Name = "Orin Blacktusk",
                    Strength = 17,
                    Constitution = 11,
                    Dexterity = 10,
                    Description = "Headsnatcha extraordinaire.",
                    RaceID = 4
                }
            );

        }
    }
}
