using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasionTeaCompany
{
    [TestClass]
    public class HerbalTea
    {
        IWebDriver driver;
        static string _expectedUrl = "@http://www.practiceselenium.com/menu.html";

        [TestInitialize]
        void Setup()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.practiceselenium.com/welcome.html");
        }

        [TestMethod]
        public void OpenClickSeeCollection()
      {
          driver.FindElement(By.Id("wsb-button-00000000-0000-0000-0000-000450914890")).Click();
          Assert.AreEqual(_expectedUrl, driver.Url, "Urls are not equal");
      }

        [TestCleanup]
        void Cleanup()
        {
            driver.Quit();
        }
    }
}