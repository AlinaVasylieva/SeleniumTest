using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasionTeaCompany
{
    [TestClass]
   public class WelcomeMoreFunction
    {
        IWebDriver driver;
        static string _expectedUrlMoreLinkFirst = "@http://www.practiceselenium.com/menu.html";
        static string _expectedTitleMoreLinkSecond = "Menu";

        [TestInitialize]
        void Setup()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.practiceselenium.com/welcome.html");
        }

        [TestMethod]

       public void OpenMoreLinkOne()
        {
            driver.FindElement(By.ClassName("editor_sidebarmore")).Click();
            Assert.AreEqual(_expectedUrlMoreLinkFirst, driver.Url, "Urls are not equal");
        }

       [TestMethod]

       public void OpenMoreLinkTwo()
        {
            driver.FindElement(By.ClassName("editor_sidebarmore")).Click();
            Assert.AreEqual(_expectedTitleMoreLinkSecond, driver.Title, "Titles are not equal");
        }
       [TestCleanup]
       void Cleanup()
       {
           driver.Quit();
       }
    }
}
