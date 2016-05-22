using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PasionTeaCompany
{
    [TestClass]
    public class CheckOut : BaseTest
    {
        [TestMethod()]
        public void CheckOutDropDown()
        {            
            driver.FindElement(By.XPath("//*[@id='wsb-nav-00000000-0000-0000-0000-000450914915']/ul/li[5]/a")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("Amely1616@rambler.ru");
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("Alina");
            driver.FindElement(By.Id("address")).SendKeys("Polska, Lodz, Plac Komuny 45/6");
            
            var select = driver.FindElement(By.Id("card_type"));
            var selectElement = new SelectElement(select);
            
            selectElement.SelectByText("Visa");
            driver.FindElement(By.XPath("//*[@id='card_number']")).SendKeys("1234 4557 5689 7890");
            driver.FindElement(By.XPath("//*[@id='cardholder_name']")).SendKeys("Alina Marchenko");
            driver.FindElement(By.XPath("//*[@id='verification_code']")).SendKeys("1254");
            driver.FindElement(By.XPath("//*[@id='wsb-element-00000000-0000-0000-0000-000452010925']/div/div/form/div/button")).Submit();
        }

        [TestMethod()]
        public void CheckOutCancelClick()
        {
            driver.FindElement(By.XPath("//*[@id='wsb-nav-00000000-0000-0000-0000-000450914915']/ul/li[5]/a")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            // click cancel
            driver.FindElement(By.XPath("//*[@id='wsb-element-00000000-0000-0000-0000-000452010925']/div/div/form/div/a")).Click();
            // assert - menu page by title
            Assert.IsTrue(driver.Title.Equals("Menu"));
        }
    }
}
