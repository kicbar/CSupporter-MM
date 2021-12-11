using CSupporter.Modules.View.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services
{
    public class ProductRequestService : BaseService, IProductRequestService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductRequestService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public Task<T> GetAllProducts<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetProductById<T>(int factureId)
        {
            throw new NotImplementedException();
        }
    }
}
