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
        private IWebElement _emailInputElement => Driver.FindElement(By.Id("Input_Email"));
        private IWebElement _passwordInputElement => Driver.FindElement(By.Id("Input_Password"));
        private IWebElement _loginInputElement => Driver.FindElement(By.Id("login-submit"));
        


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

        // change later
        public void GoToLoginPage()
        {
            Driver.Navigate().GoToUrl("https://localhost:44320/Identity/Account/Login");
        }
        public void FillEmail(string email)
        {
            _emailInputElement.SendKeys(email);
            
        }
        public void FillPassword(string password)
        {
            _passwordInputElement.SendKeys(password);
        }

        public void LoginButtonClick()
        {
            _loginInputElement.Click();
        }
    }
}
