using HeroRPG.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroRPG.Data
{
    public class HeroRPG_DbContext : DbContext
    {
        public HeroRPG_DbContext(DbContextOptions<HeroRPG_DbContext> dbContextOptions) : base(dbContextOptions)
        {
        }


        public virtual DbSet<Hero> Heroes { get; set; } = null!;
        public virtual DbSet<Race> Races { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HeroRPG_DbContext).Assembly);
        }
    }
}
