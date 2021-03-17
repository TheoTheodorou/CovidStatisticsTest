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

        [AfterScenario]
        public void TearDown()
        {
            CS_Website.Driver.Quit();
            CS_Website.Driver.Dispose();
        }
    }
}
