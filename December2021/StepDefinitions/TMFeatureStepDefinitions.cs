using System;
using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace December2021.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"\[I logged into TurnUp Portal successfully]")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            loginPageObj.LoginSteps(driver);
        }

        [Given(@"\[I navigate to Time and Material page]")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMPage(driver);
        }

        [When(@"\[I create Time and Material Record]")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            // TMPage object initialization and definition
            tmPageObj.CreateTM(driver);
        }

        [Then(@"\[The record should be created Successfully]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string actualCode = tmPageObj.GetCode(driver);
            string actualTypeCode = tmPageObj.GetTypeCode(driver);
            string actualDescription = tmPageObj.GetActualDescription(driver);
            string actualPrice = tmPageObj.GetActualPrice(driver);

            Assert.That(actualCode == "PDecember2012", "Actual Code and expected code do not match.");
            Assert.That(actualTypeCode == "M", "Actual Typecode and expected Typecode do not match.");
            Assert.That(actualDescription == "PDecember2012", "Actual Description and expected Description do not match.");
            Assert.That(actualPrice == "$305.00", "Actual Price and expected Price do not match.");

        }

        [When(@"\[I update '([^']*)' an existing Time and Material Record]")]
        public void WhenIUpdateAnExistingTimeAndMaterialRecord(string p0)
        {
            //TMPage object initialization and definition
            tmPageObj.EditTM(driver, p0);
        }

        [Then(@"\[The record should have an updated '([^']*)']")]
        public void ThenTheRecordShouldHaveAnUpdated(string p0)
        {
            string editedDescription = tmPageObj.GetEditedDescription(driver);

            Assert.That(editedDescription == p0, "Actual description and expected description do not match.");
        }

        [When(@"\[I delete existing Time and Material record]")]
        public void WhenIDeleteExistingTimeAndMaterialRecord()
        {
            tmPageObj.DeleteTM(driver);
        }

        [Then(@"\[The record should have deleted]")]
        public void ThenTheRecordShouldHaveDeleted()
        {
            string GetDeletedCode = tmPageObj.GetDeletedCode(driver);

            Assert.That(GetDeletedCode != "TEditedDecember2012", "Actual record and expected record do not match.");
        }

    }
}
