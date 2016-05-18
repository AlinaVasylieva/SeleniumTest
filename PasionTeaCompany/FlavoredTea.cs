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
    public class FlavoredTea
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
          driver.FindElement(By.Id("wsb-element-00000000-0000-0000-0000-000450914899")).Click();
          Assert.AreEqual(_expectedUrl, driver.Url, "Urls are not equal");
          
          //string a = driver.FindElement(By.XPath("//*[@id='wsb-element-00000000-0000-0000-0000-000451934628']/div/pre/span")).Text; //it should be an element that contains text on the web page
          //Assert.IsTrue(a.Contains("Green tea originated in China"));
          //Assert.IsFalse(a.StartsWith("Bla bla bla"));
          //Assert.IsTrue(a.EndsWith("dietary supplements and cosmetic items."));
          //Assert.IsTrue(a.Substring(5, 3) == "tea");
      }

        [TestCleanup]
        void Cleanup()
        {
            driver.Quit();
        }
    }
}
