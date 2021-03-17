using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStatistics.lib.pages
{
    public class CS_HomePage
    {
        public CS_HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
    }
}
