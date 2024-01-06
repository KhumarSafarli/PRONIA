using Microsoft.EntityFrameworkCore;
using Pronia.Entities;

namespace Pronia.DAL
{
    public class ProniaDbContext : DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
        {

        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PlantImage> PlantImages { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<PlantCategory> PlantCategories { get; set; }
        public DbSet<PlantInformation> PlantInformations { get; set; }
        public DbSet<PlantTag> PlantTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var item in modelBuilder.Model.
                                    GetEntityTypes()
                                    .SelectMany(e => e.GetProperties()
                                                     .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?))))
            {
                item.SetColumnType("decimal(6,2)");
            }
            base.OnModelCreating(modelBuilder);
        }

    }
}