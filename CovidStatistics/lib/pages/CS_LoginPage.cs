using CovidStatisticsTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace CovidStatistics.lib.pages
{
    public class CS_LoginPage
    {
        private IWebElement _loginMainButton => Driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[2]/a"));
        private IWebElement _loginButton => Driver.FindElement(By.XPath("//*[@id='login - submit']"));

        private string _loginPageUrl = AppConfigReader.LoginPageUrl;
        private string _baseUrl = AppConfigReader.BaseUrl;
        private IWebElement _emailField => Driver.FindElement(By.Id("email"));
        private IWebElement _passwordField => Driver.FindElement(By.Id("passwd"));

        public CS_LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public void NavigateToHome()
        {
            Driver.Navigate().GoToUrl(_loginPageUrl);
        }
        
        public void Navigate()
        {
            Driver.Navigate().GoToUrl(_baseUrl);
        }

        public void ClickSigninButton()
        {
            _loginMainButton.Click();
        }
        public void EnterEmailField(string validEmail)
        {
            _emailField.SendKeys(validEmail);
        }

        public void EnterPasswordField(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _loginButton.Click();
        }


    }
}
