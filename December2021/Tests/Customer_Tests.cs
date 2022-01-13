using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace December2021
{
    class Customer_Tests : CommonDriver
    {
        [Test, Order(1), Description("Check if user is able to Create record with valid data")]
        public void CreateCustomer()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToCustomerPage(driver);

            // Customer page object initialization and definition
            CustomerPage createCustomerObj = new CustomerPage();
            createCustomerObj.CreateCustomer_Test(driver);
        }

        [Test, Order(2), Description("Check if user is able to Edit record with valid data")]

        public void EditCustomer()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToCustomerPage(driver);

            // Customer page object initialization and definition
            CustomerPage editCustomerObj = new CustomerPage();
            editCustomerObj.EditCustomer_Test(driver);
        }

        [Test, Order(3), Description("Check if user is able to Delete record")]

        public void DeleteCustomer()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToCustomerPage(driver);

            // Customer page object initialization and definition
            CustomerPage deleteCustomerObj = new CustomerPage();
            deleteCustomerObj.DeleteCustomer_Test(driver);
        }
    }
}
