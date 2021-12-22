using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace December2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Create time and material record

            // Click on create new button

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            try
            {
                // Select typecode from Dropdown list

                IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
                typeCodeDropdown.Click();
                Thread.Sleep(2000);
                //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='TypeCode_listbox']/li[1]", 3);

                IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
                materialOption.Click();

                // Identify the code textbox and input a code

                IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
                codeTextbox.SendKeys("TDecember2012");

                // Identify the Discription and input a description 

                IWebElement discriptionTextbox = driver.FindElement(By.Id("Description"));
                discriptionTextbox.SendKeys("TDecember2012");

                // Identify the Price textbox and input a price
                IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                priceTag.Click();

                IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
                priceTextbox.SendKeys("305");


                // Click on Save Button

                IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
                saveButton.Click();
                //Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);
                Thread.Sleep(3000);


                // go to last page button

                IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                lastPageButton.Click();
                Thread.Sleep(2000);

                // check if record created is present in the table and has expected value

                IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

                // Option 1
                Assert.That(actualCode.Text == "TDecember2012", "Actual code and expected code do not match.");

                // Option 2
                //if (actualCode.Text == "TDecember2012")
                //{
                //    Assert.Pass("Material record created Successfully. Test passed.");
                //}
                //else
                //{
                //    Assert.Fail("Material record not created. Test failed.");
                //}
            }
            catch (Exception ex)
            {
                Assert.Fail("Material record did not created.", ex.Message);
            }
        }
        public static void EditTM(IWebDriver driver)
        {
            Thread.Sleep(3000);

            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            goToLastPageButton.Click();

            // Go to last page last record
            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "TDecember2012")
            {
                // click on edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }

            //try
            //{
                // Edit Current Code 
                IWebElement editCode = driver.FindElement(By.Id("Code"));
                editCode.Clear();
                editCode.SendKeys("EditedDecember2012");

                // Edit Current Description
                IWebElement editDescription = driver.FindElement(By.Id("Description"));
                editDescription.Clear();
                editDescription.SendKeys("EditDecember2012");
                Thread.Sleep(3000);
                //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]", 4);

                //Edit Current Price
                IWebElement editPriceTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                IWebElement editPriceInput = driver.FindElement(By.Id("Price"));

                editPriceTextBox.Click();
                editPriceInput.Clear();
                editPriceTextBox.Click();
            editPriceInput.SendKeys("177");
                                            
                Thread.Sleep(3000);

                // Click on Save Button
                IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
                editSaveButton.Click();
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 3);

            // Go to last page button
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(2000);

            // Check if edited record has edit the value
            IWebElement editedLastValue = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

                if (editedLastValue.Text == "EditedDecember2012")
                {
                    Assert.Pass("Material record edited successfully. Test passed.");
                }
                else
                {
                    Assert.Fail("Edit record is not created. Test failed.");
                }
            //}
            //catch (Exception ex)
            //{
            //    Assert.Fail("Material record did not edited." ,ex.Message);
            //}
        }
        public static void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(3000);

            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "EditedDecember2012")
            {
                // Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(2000);

                // Click on Ok
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted.");
            }

            // Assert that Time record has been deleted.
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn1.Click();
            Thread.Sleep(2000);
        }
    }
}
