using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasionTeaCompany
{
    [TestClass]
    public class Menu : BaseTest
    {
        //static string _expectedUrl = "http://www.practiceselenium.com/menu.html";

        
        [TestMethod()]
        public void CheckOutButtonsAvailability()
      {
        driver.Url = ("http://www.practiceselenium.com/menu.html");
          //Getting all checkout buttons

        List<IWebElement> buttons = driver.FindElements(By.XPath("//span[contains(@class, 'button-content wsb-button-content') and text() = 'Check Out']")).ToList();
        Assert.IsTrue(buttons.Count == 3, "Incorrect number of buttons, actual:" + buttons.Count.ToString());

            //TO SURF THE LIST IN DEBUG MODE
        //foreach (var b in buttons)
        //{
        //    Debug.WriteLine(b.Text);
        //}
          
          //ASSERTION AS EXAMPLE
          //string a = driver.FindElement(By.XPath("//*[@id='wsb-element-00000000-0000-0000-0000-000451934628']/div/pre/span")).Text; //it should be an element that contains text on the web page
          //Assert.IsTrue(a.Contains("Green tea originated in China"));
          //Assert.IsFalse(a.StartsWith("Bla bla bla"));
          //Assert.IsTrue(a.EndsWith("dietary supplements and cosmetic items."));
          //Assert.IsTrue(a.Substring(5, 3) == "tea");
      }

    }
}
