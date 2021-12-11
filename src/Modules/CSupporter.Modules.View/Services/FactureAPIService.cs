using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services
{
    public class FactureAPIService : IFactureAPIService
    {
        public Task<FacturesDto> SendDeleteRequest(int factureId)
        {
            throw new NotImplementedException();
        }

        public Task<List<FacturesDto>> SendGetAllRequest()
        {
            throw new NotImplementedException();
        }

        public Task<FacturesDto> SendGetRequest(int factureId)
        {
            throw new NotImplementedException();
        }

        public Task<FacturesDto> SendPostRequest(FacturesDto facturesDto)
        {
            throw new NotImplementedException();
        }

        public Task<FacturesDto> SendUpdateRequest(FacturesDto facturesDto)
        {
            throw new NotImplementedException();
        }
    }
}
