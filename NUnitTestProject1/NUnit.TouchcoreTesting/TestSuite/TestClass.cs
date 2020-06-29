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
        
        [Test]
        public void Verify_Login_CheckUsername_Logout()
        {
            login_logout.navigateToLinkedin(driver, linkedinURL);
            login_logout.Login(driver, email, password);
            validations.validateTextInElement(driver, PageObject.UsernameHome, Homepagename);
            login_logout.Logout(driver);

        }


        [Test]
        public void Verify_Headline_on_profilepage()
        {
            login_logout.navigateToLinkedin(driver, linkedinURL);
            login_logout.Login(driver, email, password);
            validations.validateTextInElement(driver, PageObject.UsernameHome, Homepagename);
            profile_page.navigatetoProfile(driver);
            login_logout.Logout(driver);

        }

        [Test]
        public void Verify_Editprofile_User_withRandomData()
        {
            login_logout.navigateToLinkedin(driver, linkedinURL);
            login_logout.Login(driver, email, password);
            profile_page.navigatetoProfile(driver);
            profile_page.Editprofileheadlinerandomdata(driver);
            login_logout.Logout(driver);

        }


        [Test]
        public void Verify_industry_Selection()
        {
            login_logout.navigateToLinkedin(driver, linkedinURL);
            login_logout.Login(driver, email, password);
            validations.validateTextInElement(driver, PageObject.UsernameHome, Homepagename);
            profile_page.navigatetoProfile(driver);
            profile_page.EditprofileIndustrydropdown(driver);
            login_logout.Logout(driver);

        }

        }
}
