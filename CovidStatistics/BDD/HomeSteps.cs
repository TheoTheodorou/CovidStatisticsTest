using CovidStatistics.lib.pages;
using CovidStatisticsTest;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CovidStatistics.BDD
{
    [Binding]
    public class HomeSteps
    {

        public CS_Website CS_Website { get; } = new CS_Website("chrome");

        [Given(@"that I am on home page")]
        public void GivenThatIAmOnHomePage()
        {
            CS_Website.CS_HomePage.Visit();
        }


        [Then(@"I cannot see the records link")]
        public void ThenICannotSeeTheRecordsLink()
        {
            bool recordLinkExist = CS_Website.CS_HomePage.DoesDayRecordLinkExist();
            Assert.That(!recordLinkExist);
        }

        // change later to login -- CODE FOR LOGIN
        [Given(@"that I am on login page")]
        public void GivenThatIAmOnLoginPage()
        {
            CS_Website.CS_HomePage.GoToLoginPage();
        }

        [Given(@"I fill email with ""(.*)""")]
        public void GivenIFillEmailWith(string p0)
        {
            CS_Website.CS_HomePage.FillEmail(p0);
        }

        [Given(@"I fill password with ""(.*)""")]
        public void GivenIFillPasswordWith(string p0)
        {
            CS_Website.CS_HomePage.FillPassword(p0);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            CS_Website.CS_HomePage.LoginButtonClick();
        }

        [Then(@"I see the day record link")]
        public void ThenISeeTheDayRecordLink()
        {
            bool recordLinkExist = CS_Website.CS_HomePage.DoesDayRecordLinkExist();
            Assert.That(recordLinkExist);
        }

        [AfterScenario]
        public void TearDown()
        {
            CS_Website.Driver.Quit();
            CS_Website.Driver.Dispose();
        }
    }
}
