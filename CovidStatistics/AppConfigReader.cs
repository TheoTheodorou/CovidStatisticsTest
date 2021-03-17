using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStatisticsTest
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = "https://localhost:44320/";
        public static readonly string LoginPageUrl = "https://localhost:44320/Identity/Account/Login";
    }
}
