using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.TouchcoreTesting
{
    class BasicMethods
    {

        public void clickElement(IWebDriver driver, By element)
        {
             driver.FindElement(element).Click();
        }

        public void sendKeys(IWebDriver driver, By element, string keys)
        {
             driver.FindElement(element).SendKeys(keys);
        }

        public string GetValue(IWebDriver driver, By element, string keys)
        {
           string value = driver.FindElement(element).Text;
            return value;
            
        }

        public void Selectelement(IWebDriver driver, By element)
        {
            Random _random = new Random();
            
            new SelectElement(driver.FindElement(element)).SelectByIndex(_random.Next(1, 100));

        }



        public string randomdatagenerator()
        {
            Random ran = new Random();

            String b = "abcdefghijklmnopqrstuvwxyz";

            int length = 6;

            String random = "";

            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }

            return random;
        }

    }
}
