using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<StreetToNeighborhood> StreetToNeighborhood { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NumberOfRooms> NumberOfRooms { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyDetail> PropertyDetails { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Parasha> Parashot { get; set; }
        public DbSet<PropertyForShabatDetail> PropertyForShabatDetails { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.EmailAdress)
                .IsUnique();
        }
    }
}
