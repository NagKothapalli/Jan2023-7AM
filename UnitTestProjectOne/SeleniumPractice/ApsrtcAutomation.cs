using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        [TestMethod]
        public void LaunchApplication()
        {
            Debug.WriteLine("Test Case : Launch Application");
            driver.Navigate().GoToUrl("https://www.apsrtconline.in/");
        }
    }

}
