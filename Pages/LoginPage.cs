using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace March2021.Pages
{
    class LoginPage
    {
        public void LoginSptes(IWebDriver driver)
        {
            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            // Identiry username textbox and input username 
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // Identify password and input password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Identify login button
            IWebElement login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            login.Click();

            //verify login page
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Test passed,logged in sucessfully");
            }
            else
            {
                Console.WriteLine("test faild, logged in failed");
            }
        }
    }
}
