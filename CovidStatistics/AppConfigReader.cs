using System.Configuration;

namespace CovidStatisticsTest
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = "https://localhost:44320/";
        public static readonly string RegisterUrl = ConfigurationManager.AppSettings["register_url"];
    }
}
