using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace December2021 // Note: actual namespace depends on the project name.
{
    class TM_Tests : CommonDriver
    {
        [Test, Order(1), Description("Cehck if user is able to create a Material record with valid data")]
        public void CreateTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TMPage object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit a Material record with valid data")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TMPage object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver, "dummy", "dummy1");
        }

        [Test, Order(3), Description("Check if user is able to delete an existing Material record")]
        public void DeleteTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TMPage object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }
    }
}

