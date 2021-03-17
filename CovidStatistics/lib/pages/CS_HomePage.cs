using CovidStatisticsTest;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        // url of page
        private readonly string _homePageUrl = AppConfigReader.HomePageUrl;
        //private readonly string _test = "https://google.com";

        // elements


        // helper methods for test
        public void Visit()
        {
            Driver.Navigate().GoToUrl(_homePageUrl);
            Thread.Sleep(3000);
        }

        public bool DoesDayRecordLinkExist()
        {
            try
            {
                Driver.FindElement(By.LinkText("Day Records"));
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
