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
        IWebDriver driver; //null
        public GmailAutomation()
        {
            driver = new ChromeDriver();
        }
        String expectedTitle = "Gmail";
        [TestInitialize]
        public void LaunchApplication()
        {
            Debug.WriteLine("Test Case : Launch Application");
            //Open an empty chrome browser : If a call the constructor of ChromeDriver class then it will open an empty chrome browser
            //ChromeDriver driver = new ChromeDriver();
            //IWebDriver driver = new ChromeDriver();
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
           
        }

        //OpenQA.Selenium.NoSuchElementException
        //Execution flow : Instance variables will be loaded -> Default Constructor -> TestIntialize  -> TestMethod
        [TestMethod]
        public void LoginToApplication()
        {
            Debug.WriteLine("Test Case : Login To Application");
            //By by = new By();
            //IWebDriver driver = new ChromeDriver();
            driver.FindElement(By.Name("identifier")).SendKeys("nag022");
            IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.ClassName("VfPpkd-vQzf8d"));
            //IWebElement nextBtn = elements.ElementAt(1); //index = 0 1 2 3 .....
            //nextBtn.Click();
            for(int i=0;i<elements.Count;i++)
            {
                IWebElement element = elements.ElementAt(i);
                String txt =  element.Text;
                Debug.WriteLine("Trext on the element :" + txt);
                if (txt.Equals("Next"))
                {
                    element.Click();
                    break;
                }
            }
            /* By byobject = By.Name("identifier");
            IWebElement email = driver.FindElement(byobject);
            email.Click();
            email.SendKeys("dfsdfggdfgfdgfd");
            email.Clear();
            email.SendKeys("nag022");*/

        }
        //Selectors / Locators from By class : id , name , class , css , tagname, linktext , partialLinktext , xpath
        // WebDriver class : FindElement , FindElements , Navigate , GotoURL , Title , CurrentURL , WindowHAndle
        // WebElement : Click , Clear , SendKeys , Text ,
        
        [TestMethod]
        public void CreateAccount()
        {
            driver.FindElement(By.Name("identifier")).SendKeys("nag022");
            IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.ClassName("VfPpkd-vQzf8d"));
            for (int i = 0; i < elements.Count; i++)
            {
                IWebElement element = elements.ElementAt(i);
                String txt = element.Text;
                Debug.WriteLine("Trext on the element :" + txt);
                if (txt.Equals("Create account"))
                {
                    element.Click();
                    break;
                }
            }
        }












    }
}
