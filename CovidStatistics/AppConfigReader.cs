using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStatisticsTest
{
    public class AppConfigReader
    {
        // needs to be inside BDD folder
        //public static readonly string HomePageUrl = ConfigurationManager.AppSettings["homepage_url"];

        public static readonly string HomePageUrl = "https://localhost:44320/";
    }
}
