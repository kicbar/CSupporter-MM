using CSupporter.Modules.Products.Domain.Entities;
using CSupporter.Shared.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CSupporter.Modules.Products.Infrastructure.Data
{
    public class CSupporterDbContext : DbContext
    {
        public CSupporterDbContext()
        {

        }

        private readonly string _connectionString = DbOptions.ConnectionString;

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
