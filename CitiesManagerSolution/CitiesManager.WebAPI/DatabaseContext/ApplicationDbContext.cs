using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {
            
        }
        public ApplicationDbContext() { }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City() {CityId = Guid.Parse("361C5CC2-6D8F-4365-B717-D216F09E35D9"), CityName="New York"} );
            modelBuilder.Entity<City>().HasData(new City() {CityId = Guid.Parse("F6A0B257-9904-4FF4-92C4-196B27D3E982"), CityName = "London"});
        }
    }
}
