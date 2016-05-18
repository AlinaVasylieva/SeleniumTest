﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;

namespace PasionTeaCompany
{
    [TestClass]
    public class LetsTalkTeaTest : BaseTest
    {
        static string _expectedMessage = "Thank you sending us your information. We will get back to you with your Chai :)";
   

        [TestMethod]
        public void FormSubmit()
        {
            driver.FindElement(By.Name("name")).SendKeys("Alina");
            driver.FindElement(By.Name("email")).SendKeys("Amely1616@rambler.ru");
            driver.FindElement(By.Name("subject")).SendKeys("TeaPurchase");
            driver.FindElement(By.Name("message")).SendKeys("Test");
            driver.FindElement(By.ClassName("form-submit")).Click();
            
            //Assert.AreEqual(_expectedMessage, driver.FindElement(By.Id(_expectedMessage)), "IDs are not equal");
            
            //Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));

            IWebElement succesText = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='msg_78ea690540a24bd8b9dcfbf99e999fea']")));
            string actualText = succesText.Text;
            Assert.AreEqual(_expectedMessage, actualText, "IDs are not equal");
        }

        public static Func<IWebDriver, IWebElement> ElementIsClickable(By locator)
        {
            return driver =>
            {
                var element = driver.FindElement(locator);
                return (element != null && element.Displayed && element.Enabled) ? element : null;
            };
        }
    }
}
