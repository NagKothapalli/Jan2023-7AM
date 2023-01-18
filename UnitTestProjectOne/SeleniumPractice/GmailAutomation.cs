﻿using System;
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
    public class GmailAutomation
    {
        [TestMethod]
        public void LaunchApplication()
        {
            Debug.WriteLine("Test Case : Launch Application");
            //Open an empty chrome browser : If a call the constructor of ChromeDriver class then it will open an empty chrome browser
            //ChromeDriver driver = new ChromeDriver();
            IWebDriver driver = new ChromeDriver();
            //Call the URL of the application to be automated
            driver.Navigate().GoToUrl("https://gmail.com");
            String sessionID = driver.CurrentWindowHandle;
            Debug.WriteLine("Session ID :" + sessionID);
        }
    }
}