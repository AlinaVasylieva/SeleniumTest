using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;


namespace PasionTeaCompany
{
    [TestClass]   
    public class Welcome : BaseTest
    {
        static string _expectedWelcomeTitleName = "Welcome";
        static string _expectedLinkTitleName = "Selenium " + "Framework" + "@|Selenium, Cucumber,Ruby, Java et al.";
        static string _expectedFacebookUrl = "https://www.facebook.com/dialog/share?app_id=140586622674265&display=popup&href=http%3A%2F%2Fwww.practiceselenium.com%2Fwelcome.html%23.VxyrW8qDwMo.facebook&picture=&title=Welcome&description=&redirect_uri=http%3A%2F%2Fs7.addthis.com%2Fstatic%2Fthankyou.html";
        static string _expectedTwitterUrl = "https://twitter.com/intent/tweet?text=Welcome&url=http%3A%2F%2Fwww.practiceselenium.com%2Fwelcome.html%23.Vxysayad8T8.twitter&related=";
        static string _expectedGoogleUrl = "https://plus.google.com/share?url=http%3A%2F%2Fwww.practiceselenium.com%2Fwelcome.html%23.VxytId5UJHw.google_plusone_share&t=Welcome";
        IWebDriver driver;
        

        [TestMethod()]
        public void WebPageOpenByHyperlink()
        {            
            driver.Navigate().GoToUrl("http://www.seleniumframework.com");
            Assert.AreEqual(_expectedLinkTitleName, driver.Title, "Titles are not equal");
        }

         [TestMethod()]
        public void SocialLinksOpen()
        {
            driver.FindElement(By.ClassName("at-icon at-icon-facebook")).Click();
            Assert.AreEqual(_expectedFacebookUrl, driver.Url, "Urls are not equal");
            
            driver.FindElement(By.XPath("//*[@id=('desktop-00000000-0000-0000-0000-000450914912']/a[2]/span/svg")).Click();
            Assert.AreEqual(_expectedFacebookUrl, driver.Url, "Urls are not equal");
       
            driver.FindElement(By.ClassName("addthis_button_google_plusone_share wsb-social-share-button at300b")).Click();
            Assert.AreEqual(_expectedGoogleUrl, driver.Url, "Urls are not equal");
             //E-mail - how to test pop-ups?
        }

        [TestMethod()]
        public void GetAdvText()
         {
             var advText = driver.FindElement(By.XPath("//*[@id='wsb-element-00000000-0000-0000-0000-000450914881']/div/p/span")).Text;
             Assert.AreEqual("", advText);
         }
    }
}
