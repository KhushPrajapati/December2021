using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace December2021 // Note: actual namespace depends on the project name.
{
    [TestFixture]
    class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            LoginPage.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTM_Test()
        {
            // TMPage object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test]
        public void EditTM_Test()
        {
            // TMPage object initialization and definition
            TMPage tmPageObj = new TMPage();
            TMPage.EditTM(driver);
        }

        [Test]
        public void DeleteTM_Test()
        {
            // TMPage object initialization and definition
            TMPage tmPageObj = new TMPage();
            TMPage.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}

