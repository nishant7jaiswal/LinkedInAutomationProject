// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace NUnit.TouchcoreTesting
{
    

        [TestFixture]
        public class LinkedinTests : Hook 
        {


        [SetUp]
        public void SetUp()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [Test]
        public void Verify_Login_CheckUsername_Logout()
        {
            pageActions.navigateToLinkedin(driver, linkedinURL);
            pageActions.Login(driver, email, password);
            validations.validateTextInElement(driver, PageObject.UsernameHome, fullName);
            pageActions.Logout(driver);

        }


        [Test]
        public void Verify_Headline_on_profilepage()
        {
            pageActions.navigateToLinkedin(driver, linkedinURL);
            pageActions.Login(driver, email, password);
            validations.validateTextInElement(driver, PageObject.UsernameHome, fullName);
            pageActions.navigatetoProfile(driver);
            pageActions.Logout(driver);

        }

        [Test]
        public void Verify_Editprofile_User_withRandomData()
        {
            pageActions.navigateToLinkedin(driver, linkedinURL);
            pageActions.Login(driver, email, password);
            validations.validateTextInElement(driver, PageObject.UsernameHome, fullName);
            pageActions.navigatetoProfile(driver);
            pageActions.Editprofileheadlinerandomdata(driver);
            pageActions.Logout(driver);

        }


        [Test]
        public void Verify_industry_Selection()
        {
            pageActions.navigateToLinkedin(driver, linkedinURL);
            pageActions.Login(driver, email, password);
            validations.validateTextInElement(driver, PageObject.UsernameHome, fullName);
            pageActions.navigatetoProfile(driver);
            pageActions.EditprofileIndustrydropdown(driver);
            pageActions.Logout(driver);

        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


}
}
