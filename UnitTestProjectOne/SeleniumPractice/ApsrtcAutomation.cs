using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProjectOne.SeleniumPractice
{
    [TestClass]
    public class ApsrtcAutomation
    {
        IWebDriver driver; //null
        public ApsrtcAutomation()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [TestInitialize]
        public void LaunchApplication()
        {
            Debug.WriteLine("Test Case : Launch Application");
            driver.Navigate().GoToUrl("https://www.apsrtconline.in/");
        }
        //OpenQA.Selenium.UnhandledAlertException: unexpected alert open: {Alert text : Please select end place.}
        [TestMethod]
        public void BookBusTicket()
        {
            Debug.WriteLine("Test Case : Book Bus Ticket");
            driver.FindElement(By.XPath("//input[contains(@title,'Enter bording place')]")).SendKeys("HYDERABAD");
            Actions actions = new Actions(driver);
            actions.Pause(TimeSpan.FromSeconds(1)).SendKeys(Keys.Enter).Build().Perform();
            //driver.FindElement(By.XPath("//input[contains(@title,'Enter alighting place')]")).SendKeys("GUNTUR");
            //input[@value='Check Availability']
            driver.FindElement(By.XPath("//input[@value='Check Availability']")).Click();
            driver.SwitchTo().Alert().Accept();
            driver.FindElement(By.XPath("//input[contains(@title,'Enter alighting place')]")).SendKeys("GUNTUR");
            actions.Pause(TimeSpan.FromSeconds(1)).SendKeys(Keys.Enter).Build().Perform();
            driver.FindElement(By.XPath("//input[@name='txtJourneyDate']")).Click();
            SelectJourneyDate("29");
            driver.FindElement(By.XPath("//input[@value='Check Availability']")).Click();
        }
        [TestMethod]
        public void BookBusTicket_Actions()
        {
            Actions actions = new Actions(driver);
            IWebElement boardingPlace = driver.FindElement(By.XPath("//input[contains(@title,'Enter bording place')]"));
            actions.MoveToElement(boardingPlace).Click().SendKeys("HYDERABAD").Pause(TimeSpan.FromSeconds(1)).SendKeys(Keys.Enter).Build().Perform();
        }

        public void SelectJourneyDate(String jDate)
        {
            driver.FindElement(By.XPath("//a[text()='"+jDate+"']")).Click();
        }
    }

}

