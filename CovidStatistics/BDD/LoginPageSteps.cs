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
            CS_Website.CS_LoginPage.Navigate();
        }

        [When(@"I click the login link")]
        public void WhenIClickTheLoginLink()
        {
            CS_Website.CS_LoginPage.ClickSigninButton();
        }

        [Then(@"I go to login page")]
        public void ThenIGoToLoginPage()
        {
            Assert.That(CS_Website.GetPageTitle(), Is.EqualTo("Log in - MvcCovidStatistics"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            CS_Website.Driver.Quit();
            CS_Website.Driver.Dispose();
        }
    }
}
