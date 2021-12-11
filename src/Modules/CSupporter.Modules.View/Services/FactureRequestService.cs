using CSupporter.Modules.View.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services
{
    public class FactureRequestService : IFactureRequestService
    {
        public Task<string> GetAllFactures<T>()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetFactureById<T>(int factureId)
        {
            throw new NotImplementedException();
        }
    }
}
