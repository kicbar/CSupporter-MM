using CSupporter.Modules.View.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services
{
    public class ProductRequestService : IProductRequestService
    {
        public Task<string> GetAllProducts<T>()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetProductById<T>(int factureId)
        {
            throw new NotImplementedException();
        }
    }
}
