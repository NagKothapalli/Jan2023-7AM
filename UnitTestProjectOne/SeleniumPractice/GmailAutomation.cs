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
            //driver.FindElement(By.Name("identifier")).SendKeys("nag022");
            driver.FindElement(By.Id("identifierId")).SendKeys("nag022");
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
        [TestMethod]
        public void GmailLogin()
        {
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("nag022");
            driver.FindElement(By.XPath("//span[text()='Next']")).Click();
        }
        //Selectors / Locators from By class : id , name , class , css , tagname, linktext , partialLinktext , xpath
        // WebDriver class : FindElement , FindElements , Navigate , GotoURL , Title , CurrentURL , WindowHAndle
        // WebElement : Click , Clear , SendKeys , Text , GetAttribute
        // Actions : Keyboard events and Mouse events 
        // JavaScriptExecutor : Click
        
        [TestMethod]
        public void CreateAccount()
        {
            //driver.FindElement(By.Name("identifier")).SendKeys("nag022");
            /* IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.ClassName("VfPpkd-vQzf8d"));
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
             }*/
            driver.FindElement(By.XPath("//span[@class='VfPpkd-vQzf8d' and text()='Create account']")).Click();
        }

        //XPATH - Absolute xpath / Fixed xapth / Static xpath
        //  /html/body/div[1]/div[1]/div[2]/div/c-wiz/div/div[2]/div/div[1]/div/form/span/section/div/div/div[3]/button 
        //Relative XPATH - is like a SQL Select query - select EmpName from Employees where EmpID=22

        //tagName[@attribute='value']
        //Example    ->  //input[@type='email']

        //tagName[text()='value']
        //Example    ->  //span[text()='Next']

        //tagName[@attribute1='value1' and @attribute2='value2']
        //Example    ->  //input[@class='whsOnd zHQkBf' and @type='email']

        //tagName[text()='value' and @attribute='value' ]
        // Ex : //span[@class='VfPpkd-vQzf8d' and text()='Create account']

        //contains

        //tagName[@attribute='value']

        //tagName[text()='value']

        //tagName[@attribute1='value1' and @attribute2='value2']

        //tagName[text()='value' and @attribute='value' ]

        //tagName can be a html , head , body , span , input, div , a , img , table , tr , td , ul , li ......
        [TestMethod]
        public void ForgotEmail()
        {
            //driver.FindElement(By.TagName("button")).Click();
            /*IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.TagName("button"));
            for (int i = 0; i < elements.Count; i++)
            {
                IWebElement element = elements.ElementAt(i);
                String txt = element.Text;
                Debug.WriteLine("Trext on the element :" + txt);
                if (txt.Equals("Forgot email?"))
                {
                    element.Click();
                    break;
                }
            }*/
            //driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/c-wiz/div/div[2]/div/div[1]/div/form/span/section/div/div/div[3]/button")).Click();
            driver.FindElement(By.XPath("//button[text()='Forgot email?']")).Click();
        }
        [TestMethod]
        public void LearnMore()
        {
            //driver.FindElement(By.TagName("a")).Click();
            /*IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.TagName("a"));
            for (int i = 0; i < elements.Count; i++)
            {
                IWebElement element = elements.ElementAt(i);
                String txt = element.Text;
                Debug.WriteLine("Trext on the element :" + txt);
                if (txt.Equals("Learn more"))
                {
                    element.Click();
                    break;
                }
            }*/
            //driver.FindElement(By.LinkText("Learn more")).Click();
            //driver.FindElement(By.PartialLinkText("Learn")).Click();
            //driver.FindElement(By.XPath("//a[text()='Learn more']")).Click();
            driver.FindElement(By.XPath("//a[@aria-label='Learn more about using Guest mode']")).Click();
        }
        [TestMethod]
        public void Help()
        {
            driver.FindElement(By.LinkText("Help")).Click();
        }










    }
}
