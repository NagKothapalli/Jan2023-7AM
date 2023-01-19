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
    public class GmailAutomation
    {
        String expectedTitle = "Gmail";
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
            String currentTitle = driver.Title;
            Debug.WriteLine("Ttile of the Current Window :" + currentTitle);
            String myUrl = driver.Url;
            Debug.WriteLine("URL of the Current Window :" + myUrl);
            if(expectedTitle.Equals(currentTitle))
            {
                Debug.WriteLine("Title Validation Successful");
            }
            else
            {
                Debug.WriteLine("Title Validation Failed");
            }
            //By by = new By();
            driver.FindElement(By.Name("identifier")).SendKeys("nag");

            By byobject = By.Name("identifier");
            IWebElement email = driver.FindElement(byobject);
            email.Click();
            email.SendKeys("dfsdfggdfgfdgfd");
            email.Clear();
            email.SendKeys("nag022");
        }
        [TestMethod]
        public void LoginToApplication()
        {
            Debug.WriteLine("Test Case : Login To Application");
            
        }














    }
}
