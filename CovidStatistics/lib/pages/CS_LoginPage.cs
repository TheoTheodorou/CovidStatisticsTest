using CovidStatisticsTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace CovidStatistics.lib.pages
{
    public class CS_LoginPage
    {
        private IWebElement _loginButton => Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[2]/a"));

        private string _loginPageUrl = AppConfigReader.LoginPageUrl;

        public CS_LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl(_loginPageUrl);
        }

        public void ClickSigninButton()
        {
            _loginButton.Click();
        }


    }
}
