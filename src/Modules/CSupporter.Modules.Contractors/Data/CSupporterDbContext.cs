using CSupporter.Modules.Contractors.Entities;
using CSupporter.Shared.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _logger.LogInformation($"[DbContext] - Database start at {DateTime.Now}.");
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
