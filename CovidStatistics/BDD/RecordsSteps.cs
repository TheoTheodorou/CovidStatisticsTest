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

        [Given(@"I am on the create records page")]
        public void GivenIAmOnTheCreateRecordsPage()
        {
            CS_Website.MaxmizeWindow();
            CS_Website.CS_RecordsPage.NavigateToCreate();
        }

        [When(@"I add a record")]
        public void WhenIAddARecord()
        {
            CS_Website.CS_RecordsPage.EnterRecordDetails();
            CS_Website.CS_RecordsPage.ClickCreateButton();
        }

        [Then(@"I should see the record in the table")]
        public void ThenIShouldSeeTheRecordInTheTable()
        {
            CS_Website.CS_RecordsPage.SortTableByDescendingDates();
            Assert.That(CS_Website.CS_RecordsPage.GetFirstRecordDate().Text, Is.EqualTo("01/01/9999"));
        }

        [Given(@"I am on the records page")]
        public void GivenIAmOnTheRecordsPage()
        {
            CS_Website.CS_RecordsPage.Navigate();

        }

        [Given(@"I have created a records")]
        public void GivenIHaveCreatedARecords()
        {
            CS_Website.MaxmizeWindow();
            CS_Website.CS_RecordsPage.NavigateToCreate();
            CS_Website.CS_RecordsPage.EnterRecordDetails();
            CS_Website.CS_RecordsPage.ClickCreateButton();
        }

        [When(@"I delete the records")]
        public void WhenIDeleteTheRecords()
        {
            CS_Website.CS_RecordsPage.SortTableByDescendingDates();
            CS_Website.CS_RecordsPage.ClickFirstRecordDelete();
            CS_Website.CS_RecordsPage.ClickDeleteButton();
        }

        [Then(@"I should not see the record in the table")]
        public void ThenIShouldNotSeeTheRecordInTheTable()
        {
            Assert.That(CS_Website.CS_RecordsPage.GetFirstRecordDate().Text, !Is.EqualTo("01/01/9999"));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Remove extra records used in test
            CS_Website.MaxmizeWindow();
            CS_Website.CS_RecordsPage.SortTableByDescendingDates();

            if (CS_Website.CS_RecordsPage.GetFirstRecordDate().Text == "01/01/9999")
            {
                CS_Website.CS_RecordsPage.ClickFirstRecordDelete();
                CS_Website.CS_RecordsPage.ClickDeleteButton();
            }

            CS_Website.Driver.Quit();
            CS_Website.Driver.Dispose();
        }

    }
}
