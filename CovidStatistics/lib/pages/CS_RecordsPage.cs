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

        public void NavigateToCreate() => _driver.Navigate().GoToUrl(AppConfigReader.RecordsCreateURL);

        public void EnterRecordDetails()
        {
            _driver.FindElement(By.Id("Date")).SendKeys("01019999");
            _driver.FindElement(By.Id("NumVaccinated")).SendKeys("1000");
            _driver.FindElement(By.Id("NumDeaths")).SendKeys("1000");
            _driver.FindElement(By.Id("NumRecovered")).SendKeys("1000");
            _driver.FindElement(By.Id("NewCases")).SendKeys("1000");
        }

        public void ClickCreateButton()
        {
            _driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[6]/input")).Click();
        }

        public void SortTableByDescendingDates()
        {
            _driver.Navigate().GoToUrl("https://localhost:44320/DayRecords?sortOrder=date_desc");
        }

        public IWebElement GetFirstRecordDate()
        {
            return _driver.FindElement(By.XPath("/html/body/div/main/table/tbody/tr[1]/td[1]"));
        }

        public void ClickFirstRecordDelete()
        {
            _driver.FindElement(By.XPath("/html/body/div/main/table/tbody/tr[1]/td[6]/a[3]")).Click();
        }

        public void ClickDeleteButton()
        {
            _driver.FindElement(By.ClassName("btn-danger")).Click();
        }
    }
}
