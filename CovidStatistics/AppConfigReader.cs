using System.Configuration;

namespace CovidStatisticsTest
{
    public static class AppConfigReader
    {
        //public static readonly string BaseURL = ConfigurationManager.AppSettings["base_url"];
        //public static readonly string RegisterURL = ConfigurationManager.AppSettings["register_url"];
        //public static readonly string LoginURL = ConfigurationManager.AppSettings["login_url"];
        //public static readonly string RecordsURL = ConfigurationManager.AppSettings["records_url"];
        //public static readonly string DefaultEmail = ConfigurationManager.AppSettings["default_email"];
        //public static readonly string DefaultPassword = ConfigurationManager.AppSettings["default_password"];

        public static readonly string BaseURL = "https://localhost:44320/";
        public static readonly string RecordsURL = "https://localhost:44320/DayRecords";
        public static readonly string RecordsCreateURL = "https://localhost:44320/DayRecords/Create";
    }
}
