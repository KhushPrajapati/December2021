using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace December2021.Pages
{
    class CustomerPage
    {
        public void CreateCustomer_Test(IWebDriver driver)
        {
            /*
            // Click on Create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Identify the Name textbox and input a name
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("TDecember");

            // Click on Edit Contact button
            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            editContactButton.Click();
            Thread.Sleep(3000);

            // Identify the First name Textbox and input firstname
            //IWebElement firstNameTextbox = driver.FindElement(By.Id("FirstName"));
            IWebElement firstNameTextbox = driver.FindElement(By.XPath("//*[@id='FirstName']"));
            firstNameTextbox.SendKeys("TDecember");

            // Identify Last name textbox and input lastname
            IWebElement lastNameTextbox = driver.FindElement(By.Id("LastName"));
            lastNameTextbox.SendKeys("TDec");

            // Identify Phone textbox and input phone
            IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
            phoneTextbox.SendKeys("123456789");

            // Identify Mobile textbox and input mobile
            IWebElement mobileTextbox = driver.FindElement(By.Id("Mobile"));
            mobileTextbox.SendKeys("123456789");

            // Identify Email textbox and input email
            IWebElement emailTextbox = driver.FindElement(By.Id("email"));
            emailTextbox.SendKeys("dece@gmail.com");

            // Identify Street textbox and input street
            IWebElement streetTextbox = driver.FindElement(By.Id("Street"));
            streetTextbox.SendKeys("Abcd");

            // Identify City textbox and input city
            IWebElement cityTextbox = driver.FindElement(By.Id("City"));
            cityTextbox.SendKeys("abc");

            // Identify Postcode textbox and input postcode
            IWebElement postcodeTextbox = driver.FindElement(By.Id("Postcode"));
            postcodeTextbox.SendKeys("2113");

            // Identify Country textbox and input country
            IWebElement countryTextbox = driver.FindElement(By.Id("Country"));
            countryTextbox.SendKeys("Australia");

            // Click on Save contact button
            IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            saveContactButton.Click();
            Thread.Sleep(3000);

            // click on Same as above checkbox
            IWebElement sameAsAboveCheckbox = driver.FindElement(By.Id("IsSameContact"));
            sameAsAboveCheckbox.Click();

            // Identify GST textbox and input GST
            IWebElement gstTextbox = driver.FindElement(By.Id("GST"));
            gstTextbox.SendKeys("123");

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.Id("submitButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // Go to Administration option again
            IWebElement administrationOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationOption.Click();

            // Go to Customer option
            IWebElement customerOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
            customerOption.Click();

            // Click on last page button
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]"));
            lastPageButton.Click();
            Thread.Sleep(3000);

            // Check if record created is present in the table and has expected value
            //Assertion
            IWebElement actualName = driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]"));

            Assert.That(actualName.Text == "TDecember", "Actual name and Expected name do not match");
            */
        }

        public void EditCustomer_Test(IWebDriver driver)
        {

        }

        public void DeleteCustomer_Test(IWebDriver driver)
        {

        }
    }
}
