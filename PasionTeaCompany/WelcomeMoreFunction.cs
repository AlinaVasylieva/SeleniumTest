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
   public class WelcomeMoreFunction : BaseTest
    {
        static string _expectedUrlMoreLinkFirst = "http://www.practiceselenium.com/menu.html";
        static string _expectedTitleMoreLinkSecond = "Menu";

        [TestMethod()]
       public void OpenMoreLinkOne()
        {
            driver.FindElement(By.ClassName("editor_sidebarmore")).Click();
            Assert.AreEqual(_expectedUrlMoreLinkFirst, driver.Url, "Urls are not equal");
        }

       [TestMethod()]
       public void OpenMoreLinkTwo()
        {
            driver.FindElement(By.ClassName("editor_sidebarmore")).Click();
            Assert.AreEqual(_expectedTitleMoreLinkSecond, driver.Title, "Titles are not equal");
        }

    }
}
