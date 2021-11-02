using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Shared.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
