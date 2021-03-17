using CovidStatistics.lib.pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CovidStatistics.BDD
{
    [Binding]
    public class RecordsSteps
    {
        CS_Website CS_Website = new CS_Website("chrome");

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            CS_Website.MaxmizeWindow();
            CS_Website.CS_RecordsPage.NavigateToHomePage();
        }

        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            CS_Website.CS_RecordsPage.ClickLogoutButton();
        }

        [When(@"I enter the records url directly")]
        public void WhenIEnterTheRecordsUrlDirectly()
        {
            CS_Website.CS_RecordsPage.Navigate();
        }

        [Then(@"I should not see the records table")]
        public void ThenIShouldNotSeeTheRecordsTable()
        {
            Assert.That(CS_Website.CS_RecordsPage.GetRecordsTable(), Is.Null);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CS_Website.Driver.Quit();
            CS_Website.Driver.Dispose();
        }
    }
}
