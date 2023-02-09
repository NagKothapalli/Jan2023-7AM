using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace UnitTestProjectOne.PageObjectModel.DriverUtilities
{
    public class DriverSetup
    {
        String browser; //instnce variable
        IWebDriver driver;
        public DriverSetup() //local variable
        {
           // this.browser = browser;
        }

        public IWebDriver GetDriver(String browser)
        {
            if (browser.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (browser.Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else if (browser.Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //40
            return driver;
        }
    }
}
