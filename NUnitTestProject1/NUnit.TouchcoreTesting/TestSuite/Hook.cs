using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.TouchcoreTesting
{
    public class Hook
    {
        public IWebDriver driver;


        public Hook()
        {

            driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            
        }
        public String email = "njtester274@gmail.com"; // Replace with valid regstered email on linkedin
        public String password = "Test@1234"; // Replace with valid password used when registering
        public String username = "Nishant"; // Replace with valid username used when registering
        public string Homepagename = "Welcome, Nishant!";
        public String fullName = "Nishant TestAccount";
        public String locality = "India";
        public String linkedinURL = "https://www.linkedin.com/login";
        public LoginLogout login_logout;
        public ProfilePage profile_page;
        public Validation validations;

        [SetUp]
        public void SetUp()
        {
            login_logout = new LoginLogout();
             validations = new Validation();
            profile_page = new ProfilePage();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }

}
