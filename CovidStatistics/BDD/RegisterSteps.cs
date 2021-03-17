using CovidStatistics.lib.pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CovidStatistics.BDD
{
    [Binding]
    public class RegisterSteps
    {
        public CS_Website CS_Website { get; } = new CS_Website("chrome");

        [Given(@"I am on the register page")]
        public void GivenIAmOnTheRegisterPage()
        {
            CS_Website.MaxmizeWindow();
            CS_Website.CS_RegisterPage.Navigate();
            CS_Website.CS_RegisterPage.NavigateToRegisterPage();
        }
        
        [Given(@"I enter the email ""(.*)""")]
        public void GivenIEnterTheEmail(string p0)
        {
            CS_Website.CS_RegisterPage.SendEmailKeys();
        }
        
        [Given(@"I enter the password ""(.*)""")]
        public void GivenIEnterThePassword(string p0)
        {
            CS_Website.CS_RegisterPage.SendPasswordKeys();
            CS_Website.CS_RegisterPage.SendConfirmPasswordKeys();
        }
        
        [When(@"I click the register button")]
        public void WhenIClickTheRegisterButton()
        {
            CS_Website.CS_RegisterPage.SubmitForm();
        }
        
        [Then(@"I should be taken to the confirm email page")]
        public void ThenIShouldBeTakenToTheConfirmEmailPage()
        {
            Assert.That(CS_Website.CS_RegisterPage._alert.Text.Contains("Confirm email"));
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
