using CovidStatisticsTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace CovidStatistics.lib.pages
{
    public class CS_LoginPage
    {
        private IWebDriver _driver;
        private IWebElement _loginPageButton => Driver.FindElement(By.LinkText("Login"));
        private IWebElement _loginSubmitButton => Driver.FindElement(By.Id("login-submit"));
        private string _loginPageUrl = AppConfigReader.LoginPageUrl;
        private string _baseUrl = AppConfigReader.BaseUrl;
        private IWebElement _emailField => Driver.FindElement(By.Id("Input_Email"));
        private IWebElement _passwordField => Driver.FindElement(By.Id("Input_Password"));

        public CS_LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToHome()
        {
            Driver.Navigate().GoToUrl(_baseUrl);
        }
        
        public void Navigate()
        {
            Driver.Navigate().GoToUrl(_loginPageUrl);
        }

        public void ClickSigninButton()
        {
            _loginPageButton.Click();
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
            _loginSubmitButton.Click();
        }
    }
}
