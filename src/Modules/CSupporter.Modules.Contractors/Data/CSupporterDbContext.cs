using CSupporter.Modules.Contractors.Entities;
using CSupporter.Shared.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace CSupporter.Modules.Contractors.Data
{
    public class CSupporterDbContext : DbContext
    {

        private readonly string _connectionString = DbOptions.ConnectionString;
        public DbSet<Contractor> Contractors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contractor>().HasData(new Contractor
            {
                Id = Guid.NewGuid(),
                FirstName = "Richard",
                LastName = "Nowak",
                Address = "Warszawa, ul. Przedszkolna 15",
                CompanyName = "GM Prime RN",
                CompanyDetails = "--",
                NIP = "912-111-09-10"
            });
            modelBuilder.Entity<Contractor>().HasData(new Contractor
            {
                Id = Guid.NewGuid(),
                FirstName = "Adrian",
                LastName = "Kowalski",
                Address = "Gdański, ul. Mariacka 8",
                CompanyName = "FUH Adrian",
                CompanyDetails = "--",
                NIP = "805-111-09-10"
            });
            modelBuilder.Entity<Contractor>().HasData(new Contractor
            {
                Id = Guid.NewGuid(),
                FirstName = "Roman",
                LastName = "Romanowicz",
                Address = "Wrocław, ul. Żeromskiego 10",
                CompanyName = "KOMFORT",
                CompanyDetails = "--",
                NIP = "712-934-35-23"
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
