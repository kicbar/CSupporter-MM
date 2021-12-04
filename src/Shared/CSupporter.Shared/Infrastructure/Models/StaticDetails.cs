namespace CSupporter.Shared.Infrastructure.Models
{
    public static class StaticDetails
    {
        public static string CSupporterAPI 
        {
            get { return "https://localhost:44324/"; }
        }
        public enum ApiType { GET, POST, PUT, DELETE }
    }
}
