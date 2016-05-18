using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasionTeaCompany
{
   public class BaseTest
    {
        protected IWebDriver driver;
        WebDriverWait wait;

        [TestInitialize()]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.practiceselenium.com/welcome.html");

        }

        [TestCleanup()]
        public void Cleanup()
        {
            driver.Quit();
        }

    }
}
