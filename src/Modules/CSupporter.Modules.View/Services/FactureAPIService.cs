using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services
{
    public class FactureAPIService : IFactureAPIService
    {
        public async Task<List<FacturesDto>> SendGetAllRequest()
        {
            List<FacturesDto> facturesDto = new();
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync(ApiData.ApiAddress + "/api/facture");
                string apiResponse = await response.Content.ReadAsStringAsync();
                ApiResponseDto apiResponseDto = JsonConvert.DeserializeObject<ApiResponseDto>(apiResponse);
                if (apiResponseDto != null && apiResponseDto.IsSuccess)
                {
                    facturesDto = JsonConvert.DeserializeObject<List<FacturesDto>>(Convert.ToString(apiResponseDto.Result));
                }
            }
            return facturesDto;
        }

        public async Task<EntireFactureDto> SendGetRequest(int factureId)
        {
            EntireFactureDto factureDto = new();
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync(ApiData.ApiAddress + "/api/facture/details/" + factureId);
                string apiResponse = await response.Content.ReadAsStringAsync();
                // tu ponizej sie nie mapuje
                 factureDto = JsonConvert.DeserializeObject<EntireFactureDto>(apiResponse);
/*                if (apiResponseDto != null && apiResponseDto.IsSuccess)
                {
                    factureDto = JsonConvert.DeserializeObject<EntireFactureDto>(Convert.ToString(apiResponseDto.Result));
                }*/
            }
            return factureDto;
        }

        public Task<FacturesDto> SendPostRequest(FacturesDto facturesDto)
        {
            throw new NotImplementedException();
        }

        public Task<FacturesDto> SendUpdateRequest(FacturesDto facturesDto)
        {
            throw new NotImplementedException();
        }

        public Task<FacturesDto> SendDeleteRequest(int factureId)
        {
            throw new NotImplementedException();
        }
    }
}
