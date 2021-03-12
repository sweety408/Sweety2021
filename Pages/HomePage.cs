using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace March2021.Pages
{
    class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            // Navigate to time and material test
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(1500);
        }
    }
}

