using CovidStatisticsTest;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStatistics.lib.pages
{
    public class CS_RegisterPage
    {
        public IWebDriver _driver { get; }

        private string _registerPageUrl = AppConfigReader.BaseUrl;
        private IWebElement _registerButton => _driver.FindElement(By.LinkText("Register"));
        private IWebElement _emailField => _driver.FindElement(By.Id("Input_Email"));
        private IWebElement _passwordField => _driver.FindElement(By.Id("Input_Password"));
        private IWebElement _confirmPasswordField => _driver.FindElement(By.Id("Input_ConfirmPassword"));
        private IWebElement _submitButton => _driver.FindElement(By.Id("registerSubmit"));
        private IWebElement _confirmEmail => _driver.FindElement(By.Id("confirm-link"));
        public IWebElement _alert => _driver.FindElement(By.ClassName("pb-3"));

        public CS_RegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(_registerPageUrl);
        }

        public void NavigateToRegisterPage()
        {
            _registerButton.Click();
        }

        public void SendPasswordKeys()
        {
            _passwordField.SendKeys("Test!123");
        }

        public void SendConfirmPasswordKeys()
        {
            _confirmPasswordField.SendKeys("Test!123");
        }

        public void SendEmailKeys()
        {
            _emailField.SendKeys("test1@test.com");
        }

        public void SubmitForm()
        {
            _submitButton.Click();
        }



    }
}
