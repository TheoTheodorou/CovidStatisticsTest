using CovidStatistics.lib.pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CovidStatistics.BDD
{
    [Binding]
    public class LoginPageSteps
    {
        public CS_Website CS_Website { get; } = new CS_Website("chrome");

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            CS_Website.CS_LoginPage.NavigateToHome();
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            CS_Website.CS_LoginPage.Navigate();
        }


        [Given(@"I have entered the email (.*)")]
        public void GivenIHaveEnteredTheEmail(string email)
        {
            CS_Website.CS_LoginPage.EnterEmailField(email);
        }

        [Given(@"I have entered the password (.*)")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            CS_Website.CS_LoginPage.EnterPasswordField(password);
        }

        [When(@"I click the login link")]
        public void WhenIClickTheLoginLink()
        {
            CS_Website.CS_LoginPage.ClickSigninButton();
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            CS_Website.CS_LoginPage.ClickLoginButton();
        }


        [Then(@"I go to login page")]
        public void ThenIGoToLoginPage()
        {
            Assert.That(CS_Website.GetPageTitle(), Is.EqualTo("Log in - MvcCovidStatistics"));
        }

        [Then(@"I go to the home page")]
        public void ThenIGoToTheHomePage()
        {
            Assert.That(CS_Website.GetPageTitle(), Is.EqualTo("Home Page - MvcCovidStatistics"));
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            CS_Website.Driver.Quit();
            CS_Website.Driver.Dispose();
        }
    }
}
