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
        public String email = " jaiswalnr2@rknec.edu"; // Replace with valid regstered email on linkedin
        public String password = "Test@1234"; // Replace with valid password used when registering
        public String username = "Nishant"; // Replace with valid username used when registering
        public String fullName = "Nishant TestAccount";
        public String locality = "India";
        public String linkedinURL = "https://www.linkedin.com/login";
        public PageAction pageActions = new PageAction();
        public Validation validations = new Validation();

    }

}
