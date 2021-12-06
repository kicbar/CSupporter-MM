using CSupporter.Modules.Products.Domain.Interfaces;
using CSupporter.Modules.Products.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Products.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CSupporterDbContext _csupporterDbContext;

        public ProductRepository(CSupporterDbContext csupporterDbContext)
        {
            _csupporterDbContext = csupporterDbContext;
        }
    }
}
