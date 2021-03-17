using CovidStatisticsTest;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStatistics.lib.pages
{
    public class CS_RecordsPage
    {
        private IWebDriver _driver;
        private ICollection<IWebElement> _logoutButton => _driver.FindElements(By.CssSelector("nav-link btn btn-link text-dark"));
        private IWebElement _table => _driver.FindElement(By.ClassName("table"));

        public CS_RecordsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToHomePage() => _driver.Navigate().GoToUrl(AppConfigReader.BaseURL);

        public void Navigate() => _driver.Navigate().GoToUrl(AppConfigReader.RecordsURL);

        public void ClickLogoutButton()
        {
            if (_logoutButton.Count != 0) _logoutButton.First().Click();
        }

        public IWebElement GetRecordsTable() => _table;
    }
}
