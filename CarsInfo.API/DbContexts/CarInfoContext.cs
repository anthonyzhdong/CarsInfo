using CarsInfo.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarsInfo.Api.DbContexts
{
    public class CarInfoContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CarInfo.db");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car("911")
                {
                    Id = 1,
                    Company = "Porsche",
                    Model = "Carrera",
                    Variant = "S",
                    Year = 2023,
                    ImageUrl = "",
                });

            modelBuilder.Entity<PointOfInterest>().HasData( // Fixed incorrect syntax
                new PointOfInterest("PDK Transmission")
                {
                    Id = 2,
                    Description = "Dual-clutch automatic",
                    CarId = 1 // Assuming this is the foreign key to the Car entity
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
