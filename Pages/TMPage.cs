using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace March2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(1500);

            // Select time from drop down list
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();

            // Enetr code
            driver.FindElement(By.Id("Code")).SendKeys("march2021");

            // Enter description
            driver.FindElement(By.Id("Description")).SendKeys("march2021-Description");

            // Enter price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.Id("Price")).SendKeys("123");

            // Click save
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);


            // Go to the last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            // Validate if record is created
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "march2021")
            {
                Console.WriteLine("Test passed, Record created");
            }
            else
            {
                Console.WriteLine("Test faild, time tecored creation faild");
            }
        }

        public void EditTM(IWebDriver driver)
        {
          
         
        }
        public void DeleteTM(IWebDriver driver)
        {

        }
    }
}
