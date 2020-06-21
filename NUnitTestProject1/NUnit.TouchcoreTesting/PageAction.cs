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
    public class PageAction
    {

        BasicMethods basicMethod = new BasicMethods();
        Validation validations = new Validation();

    public void navigateToLinkedin(IWebDriver driver, String linkedinURL)
    {
        driver.Navigate().GoToUrl(linkedinURL);
        validations.validateScreenByUrl(driver, linkedinURL);
    }

    public void Login(IWebDriver driver, String email, String password)
    {
            basicMethod.clickElement(driver, PageObject.loginEmailInput);
            basicMethod.sendKeys(driver, PageObject.loginEmailInput, email);
            basicMethod.clickElement(driver, PageObject.loginPassInput);
            basicMethod.sendKeys(driver, PageObject.loginPassInput, password);
            basicMethod.clickElement(driver, PageObject.loginButton);
            // Wait up to 30s for the user to login and to be redirected to Homescreen
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
    }

    public void navigatetoProfile(IWebDriver driver)
    {
            basicMethod.clickElement(driver,PageObject.UsernameHome);
    }

    public void Logout(IWebDriver driver)
    {
            Actions builder = new Actions(driver);            
            builder.MoveToElement(driver.FindElement(PageObject.navProfilePhoto)).Perform();
            builder.MoveToElement(driver.FindElement(PageObject.logoutButton)).Click().Perform();
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
