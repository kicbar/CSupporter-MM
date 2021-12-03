namespace CSupporter.Shared.Infrastructure.Models
{
    public static class StaticDetails
    {
        public static string ContractorAPI { get; set; }
        public static string FactureAPI { get; set; }
        public static string IncomeAPI { get; set; }
        public static string ProductAPI { get; set; }
        public enum ApiType { GET, POST, PUT, DELETE }
    }
}
