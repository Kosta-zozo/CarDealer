using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarDealer.Models;

namespace CarDealer.Data
{
    public class CarDealerContext : DbContext
    {
        public CarDealerContext (DbContextOptions<CarDealerContext> options)
            : base(options)
        {
        }

        public DbSet<CarDealer.Models.FuelType> FuelType { get; set; } = default!;
        public DbSet<CarDealer.Models.Brand> Brand { get; set; } = default!;
        public DbSet<CarDealer.Models.Car> Car { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne(c => c.FuelType)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
