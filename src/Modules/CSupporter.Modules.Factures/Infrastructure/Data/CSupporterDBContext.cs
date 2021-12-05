using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Shared.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CSupporter.Modules.Factures.Infrastructure.Data
{
    public class CSupporterDbContext : DbContext
    {
        public CSupporterDbContext()
        {

        }

        private readonly string _connectionString = DbOptions.ConnectionString;

        public DbSet<Facture> Factures { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
