using HeroRPG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HeroRPG.Data
{
    public class HeroRpgDbContext : DbContext
    {
        public HeroRpgDbContext(DbContextOptions<HeroRpgDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }


        public virtual DbSet<Hero> Heroes { get; set; } = null!;
        public virtual DbSet<Race> Races { get; set; } = null!;
        public virtual DbSet<IdentityUser> IdentyUsers { get; set; } = null!;
        public virtual DbSet<IdentityUserClaim<string>> IdentityUserClaims { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HeroRpgDbContext).Assembly);
        }
    }
}
