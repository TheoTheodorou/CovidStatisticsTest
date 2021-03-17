using OpenQA.Selenium;
using SeleniumWalkthrough.lib.driver_config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStatistics.lib.pages
{
    public class CS_Website
    {
        public IWebDriver Driver { get; set; }

        // Accessible Page Object
        public CS_HomePage CS_HomePage { get; internal set; }
        public CS_LoginPage CS_LoginPage { get; internal set; }
        public CS_RecordsPage CS_RecordsPage { get; internal set; }
        public CS_RegisterPage CS_RegisterPage { get; internal set; }

        public CS_Website(string driver, int pageLoadInSecs = 15, int implicitWaitInSecs = 15)
        {
            Driver = new SeleniumDriverConfig(driver, pageLoadInSecs, implicitWaitInSecs).Driver;
            CS_HomePage = new CS_HomePage(Driver);
            CS_LoginPage = new CS_LoginPage(Driver);
            CS_RecordsPage = new CS_RecordsPage(Driver);
            CS_RegisterPage = new CS_RegisterPage(Driver);
        }

        public void MaxmizeWindow()
        {
            Driver.Manage().Window.Maximize();
        }

        public void DeleteCookies()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        public string GetPageTitle()
        {
            return Driver.Title;
        }
    }
}
