using static CSupporter.Modules.View.Models.ApiData;

namespace CSupporter.Modules.View.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
