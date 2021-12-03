using static CSupporter.Shared.Infrastructure.Models.StaticDetails;

namespace CSupporter.Shared.Infrastructure.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
