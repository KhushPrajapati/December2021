using System;
using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace December2021.StepDefinitions
{
    [Binding]
    public class EmployeeFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [Given(@"\[I logged in to TurnUp Portal successfully]")]
        public void GivenILoggedInToTurnUpPortalSuccessfully()
        {
            loginPageObj.LoginSteps(driver);
        }

        [Given(@"\[I navigate to Employee page]")]
        public void GivenINavigateToEmployeePage()
        {
            homePageObj.GoToEmployeePage(driver);
        }

        [When(@"\[I create Employee Record]")]
        public void WhenICreateEmployeeRecord()
        {
            // Employee Page object initialization and definition
            employeePageObj.CreateEmployee_Test(driver);
        }
        
        [Then(@"\[The Employee record should be created Successfully]")]
        public void ThenTheEmployeeRecordShouldBeCreatedSuccessfully()
        {
            string GetName = employeePageObj.GetName(driver);
            string GetUserName = employeePageObj.GetUserName(driver);

            Assert.That(GetName == "TEmployee2021", "Actual name and expected name do not match.");
            Assert.That(GetUserName == "TEmp2021", "Actual Username and expected username do not match.");
        }

        [When(@"\[I update '([^']*)'an existing employee record]")]
        public void WhenIUpdateAnExistingEmployeeRecord(string UserName)
        {
            employeePageObj.EditEmployee_Test(driver, UserName);
        }

        [Then(@"\[The Employee record should have an updated '([^']*)']")]
        public void ThenTheEmployeeRecordShouldHaveAnUpdated(string UserName)
        {
            string GetEditedUserName = employeePageObj.GetEditedUserName(driver);

            Assert.That(GetEditedUserName == UserName, "Actual editedUsername and expected editedUsername do not match.");
        }

        [When(@"\[I delete an existing employee record]")]
        public void WhenIDeleteAnExistingEmployeeRecord()
        {
            employeePageObj.DeleteEmployee_Test(driver);
        }

        [Then(@"\[The Employee record should have deleted]")]
        public void ThenTheEmployeeRecordShouldHaveDeleted()
        {
            string GetDeletedName = employeePageObj.GetDeletedName(driver);

            Assert.That(GetDeletedName != "EditedEmployee2021", "Actual Name and Expected Name do not match.");
        }

    }
}
