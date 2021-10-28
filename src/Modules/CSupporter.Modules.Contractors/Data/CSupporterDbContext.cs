using CSupporter.Modules.Contractors.Entities;
using CSupporter.Shared.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace CSupporter.Modules.Contractors.Data
{
    class CSupporterDbContext : DbContext
    {
        public CSupporterDbContext(ILogger<CSupporterDbContext> logger)
        {
            _logger = logger;
        }
        private readonly string _connectionString = DbOptions.ConnectionString;
        private readonly ILogger<CSupporterDbContext> _logger;

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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _logger.LogInformation($"[DbContext] - Database start at {DateTime.Now}.");
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
