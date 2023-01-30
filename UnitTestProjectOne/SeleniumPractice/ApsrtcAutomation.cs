using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
            EnterText("//input[contains(@title,'Enter alighting place')]", "GUNTUR");
            FixedWait(1);
            ClickEnter();            
            ClickElement("//input[@name='txtJourneyDate']");
            SelectJourneyDate("31");
            ClickElement("//input[@value='Check Availability']");
        }
        //**********************************XPATHS*************************
        String FromCityTxt = "//input[contains(@title,'Enter bording place')]";
        String ToCityTxt = "//input[contains(@title,'Enter alighting place')]";
        String OpenCalendarBtn = "//input[@name='txtJourneyDate']";
        String SearchButtonBtn = "//input[@value='Check Availability']";
        [TestMethod]
        public void BookBusTicket_xpath()
        {
            EnterText(FromCityTxt, "HYDERABAD");
            FixedWait(1);
            ClickEnter();
            EnterText(ToCityTxt, "GUNTUR");
            FixedWait(1);
            ClickEnter();
            ClickElement(OpenCalendarBtn);
            SelectJourneyDate("31");
            ClickElement(SearchButtonBtn);
        }
        [TestMethod]
        public void MouseActions()
        {
           // EnterText(FromCityTxt, "HYDERABAD");
            Actions actions = new Actions(driver);
            EnterText(FromCityTxt, "HYDERABAD");
            FixedWait(1);
            actions.MoveToElement(ReturnElement(FromCityTxt)).DoubleClick().Pause(TimeSpan.FromSeconds(1)).ContextClick().Build().Perform();
            // MoveToElement   - Mouse Hovering
            // ContextCLick  - Right Click
        }

        public void SelectJourneyDate(String jDate)
        {
            driver.FindElement(By.XPath("//a[text()='" + jDate + "']")).Click();
        }
        //****************Generic functions / Utility functions **************************
        public IWebElement ReturnElement(String myxpath)
        {            
            IWebElement element = driver.FindElement(By.XPath(myxpath));
            return element;
            //actions.MoveToElement(element).Click().Build().Perform();
        }
        public void ClickElement(String myxpath)
        {
            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath(myxpath));
            actions.MoveToElement(element).Click().Build().Perform();
        }
        public void EnterText(String myxpath,String text)
        {
            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath(myxpath));
            actions.MoveToElement(element).Click().SendKeys(text).Build().Perform();
        }

        public void ClickEnter()
        {
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
        public void ClickTab()
        {
            new Actions(driver).SendKeys(Keys.Tab).Build().Perform();
        }
        public void FixedWait(int timeInSeconds)
        {
            //Thread.Sleep(1000 * timeInSeconds);
            new Actions(driver).Pause(TimeSpan.FromSeconds(timeInSeconds)).Build().Perform();
        }
        //****************************************************************
        
    }

}

