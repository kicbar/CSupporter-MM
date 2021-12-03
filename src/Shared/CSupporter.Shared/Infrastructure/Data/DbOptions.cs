namespace CSupporter.Shared.Infrastructure.Data
{
    public class DbOptions
    {
        public static string ConnectionString
        {
            get { return "Server=(localdb)\\MSSQLLocalDB;Database=CSupporterDB;Trusted_Connection=True;MultipleActiveResultSets=true"; }
        }
    }
}
