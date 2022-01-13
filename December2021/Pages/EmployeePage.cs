using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace December2021.Pages
{
    class EmployeePage
    {
        public void CreateEmployee_Test(IWebDriver driver)
        {
            // Click on Create button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createButton.Click();
            Thread.Sleep(3000);

            // Identify the Name textbox and input a new Name
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("TEmployee2021");

            // Identify the Username textbox and input a new Username
            IWebElement userNameTextbox = driver.FindElement(By.Id("Username"));
            userNameTextbox.SendKeys("TEmp2021");

            // Identify the Contact textbox and input a new Contact
            IWebElement contactTextbox = driver.FindElement(By.XPath("//*[@id='ContactDisplay']"));
            contactTextbox.SendKeys("12345678");

            // Identify the Password textbox and input a new password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("Temployee@2021");

            // Identify the RetypePassword textbox and input a retype password
            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.SendKeys("Temployee@2021");

            // Identify the IsAdmin checkbox and check 
            IWebElement isAdminCheckbox = driver.FindElement(By.Id("IsAdmin"));
            isAdminCheckbox.Click();
            Thread.Sleep(3000);

            // Identify the Vehicle textbox and input a new vehicle
            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span"));
            vehicleTextbox.SendKeys("Car");

            // Identify the Group listbox and select the value 
            IWebElement groupListbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupListbox.Click();
            Thread.Sleep(3000);

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // Click on Back to List link
            IWebElement backToListLink = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToListLink.Click();
            Thread.Sleep(3000);

            // Go to the Last page button
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            lastPageButton.Click();
            Thread.Sleep(3000);
        }

        public string GetName(IWebDriver driver)
        {
            IWebElement actualName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualName.Text;
        }
        public string GetUserName(IWebDriver driver)
        {
            IWebElement actualUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return actualUsername.Text;
        }
        public void EditEmployee_Test(IWebDriver driver, string UserName)
        {
            Thread.Sleep(3000);

            // Go to the last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            goToLastPageButton.Click();

            // Edit current Name
            IWebElement editName = driver.FindElement(By.Id("Name"));
            editName.Clear();
            editName.SendKeys("EditedEmployee2021");

            // Edit current Username
            IWebElement editUserName = driver.FindElement(By.Id("Username"));
            editUserName.Clear();
            editUserName.SendKeys(UserName);                 

            // Click on Save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(3000);

            // Click on Back to List link
            IWebElement backToListLink = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToListLink.Click();
            Thread.Sleep(3000);

            // Go to Last page button
            IWebElement editedLastRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            editedLastRecord.Click();
            Thread.Sleep(3000);

            // Identify that the edited record successfully created or not
            IWebElement editedLastValue = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));            
        }

        public string GetEditedName(IWebDriver driver)
        {
            IWebElement createdName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return createdName.Text;
        }

        public string GetEditedUserName(IWebDriver driver)
        {
            IWebElement createdUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return createdUsername.Text;
        }
        public void DeleteEmployee_Test(IWebDriver driver)
        {
            Thread.Sleep(4000);

            // Go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            goToLastPageButton.Click();

            // Go to Last Edited Record
            IWebElement findLastEditedRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            if (findLastEditedRecord.Text == "EditedEmployee2021")
            {
                // Click on Delete button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(2000);

                // Click on OK
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not Deleted.");
            }

            // Assert that Employee record has been deleted
            IWebElement goToLastPageBtn = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            goToLastPageBtn.Click();
            Thread.Sleep(2000);

            // Assertion
            //Assert.That(editedName.Text != "EditedEmployee2021", "Edited Name record hasn't been deleted.");
            //Assert.That(editedUserName.Text != "EditEmp2021", "Edited UserName record hasn't been deleted.");

        }
        public string GetDeletedName(IWebDriver driver)
        {
            IWebElement editedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedName.Text;
        }
        public string GetDeletedUserName(IWebDriver driver)
        {
            IWebElement editedUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return editedUserName.Text;
        }
    }
}
