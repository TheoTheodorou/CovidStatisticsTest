using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumWalkthrough.lib.driver_config
{
    public class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(string driver, int PageLoadInSecs, int implicitWaitInSecs)
        {
            DriverSetUp(driver, PageLoadInSecs, implicitWaitInSecs);
        }

        private void DriverSetUp(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            switch (driver)
            {
                case "chrome":
                    SetChromeDriver();
                    SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
                    break;
                case "firefox":
                    SetFirefoxDriver();
                    SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
                    break;
                default:
                    throw new Exception("Please use chrome or firefox");
            }
        }

        private void SetFirefoxDriver()
        {
            Driver = new FirefoxDriver();
        }

        private void SetChromeDriver()
        {
            Driver = new ChromeDriver();
        }

        private void SetDriverConfiguration(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
