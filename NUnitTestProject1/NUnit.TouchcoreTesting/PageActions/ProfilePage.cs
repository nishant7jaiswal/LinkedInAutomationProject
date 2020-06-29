using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit.TouchcoreTesting
{
    public class ProfilePage
    {

        BasicMethods basicMethod = new BasicMethods();
        Validation validations = new Validation();


        public void navigatetoProfile(IWebDriver driver)
        {
            basicMethod.clickElement(driver,PageObject.UsernameHome);
        }


        public void Editprofileheadlinerandomdata(IWebDriver driver)
        {
            basicMethod.clickElement(driver, PageObject.editProfileLink);
            basicMethod.sendKeys(driver, PageObject.addheadline, basicMethod.randomdatagenerator());
            basicMethod.clickElement(driver, PageObject.saveProfile);
        }

        public void EditprofileIndustrydropdown(IWebDriver driver)
        {
            basicMethod.clickElement(driver, PageObject.editProfileLink);
            Thread.Sleep(8000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
            basicMethod.clickElement(driver, PageObject.addheadline);
            basicMethod.clickElement(driver, PageObject.saveProfile);
        }


    }
}
