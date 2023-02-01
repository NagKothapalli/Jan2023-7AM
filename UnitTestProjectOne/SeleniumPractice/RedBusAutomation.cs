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

namespace UnitTestProjectOne.SeleniumPractice
{
    [TestClass]
    public class RedBusAutomation
    {
        IWebDriver driver; //null
        DriverUtilities dUtils;
        public RedBusAutomation()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            dUtils = new DriverUtilities(driver); //1234
        }
        //*********************
        String LoginDropDownBtn = "//div[@id='sign-in-icon-down']";
        String SignInLnk = "//li[@id='signInLink']";
        String IframeModal = "//div[@class='modal']//iframe";
        String MobileNumTxt = "//input[@id='mobileNoInp']";
        [TestInitialize]
        public void LaunchApplication()
        {
            Debug.WriteLine("Test Case : Launch Application");
            driver.Navigate().GoToUrl("https://www.redbus.in/");
        }
        [TestMethod]
        public void BookBusTicket()
        {
            Debug.WriteLine("Test Case : Book Bus Ticket ");
            dUtils.ClickElement(LoginDropDownBtn);
            dUtils.ClickElement(SignInLnk);
            dUtils.SwitchToIframe(IframeModal);
            dUtils.EnterText(MobileNumTxt, "9959775757");
            dUtils.SwitchToDefault();
        }

    }
}
