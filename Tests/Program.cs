using March2021.Pages;
using March2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace March2021
{
    [TestFixture]
    class Program : commonDriver
    {
        // empolyee page object and create create,edit,delete test
       // Employee empObj = new Employee();
       // empObj.CreateEmployee(driver); // test 4
         //   empObj.EditTM(driver);  // test 5
           // empObj.DeleteTM(driver);  // test 6

        
       
        [SetUp]

        public void login()
        {
            // login page obj and login steps
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSptes(driver);

            // Home page object and navigate step
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);
        }
        [Test]
        public void CreateTMTest()
        {
            // TM page object and create step
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);  // test 1
            
        }
        [Test]
        public void EditTMTest()
        {
            // TM page obj and Edit step
            TMPage tmObj = new TMPage();
            tmObj.EditTM(driver);  // test 2

        }
        [Test]
        public void DeleteTesst()
        {
            // TM page obj and Delete step
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver); // test 3

        }
        [TearDown]
        public void FinalSteps()
        {
            driver.Quit();
        }

    }
}
