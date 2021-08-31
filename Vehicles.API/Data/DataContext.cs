using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vehicles.API.Data.Entities;
using Vehicles.API.Models;

namespace Vehicles.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<VehicleType> vehicleTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Detail> details { get; set; }
        public DbSet<History> histories { get; set; }
        public DbSet<VehiclePhoto> vehiclePhotos { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Procedure>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Brand>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<DocumentType>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Vehicle>().HasIndex(x => x.Plaque).IsUnique();
        }
    }
}
