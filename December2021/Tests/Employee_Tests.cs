using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;

namespace December2021
{
    class Employee_Tests: CommonDriver
    {
        [Test, Order(1), Description("Check if user is able to create an Employee record with valid data")]
        public void CreateEmployee()
        {
            // Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Employee Page object initialization and definition
            EmployeePage createEmployeeObj = new EmployeePage();
            createEmployeeObj.CreateEmployee_Test(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit an Employee record with valid data")]
        public void EditEmployee()
        {
            // Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Employee Page object initialization and definition
            EmployeePage editEmployeePage = new EmployeePage();
            editEmployeePage.EditEmployee_Test(driver, "dummy", "dummy");
        }

        [Test, Order(3), Description("Check if user is able to delete an existing Employee record")]
        public void DeleteEmployee()
        {
            // Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Employee Page object initialization and definition
            EmployeePage deleteEmployeePage = new EmployeePage();
            deleteEmployeePage.DeleteEmployee_Test(driver);

        }
    }
}
