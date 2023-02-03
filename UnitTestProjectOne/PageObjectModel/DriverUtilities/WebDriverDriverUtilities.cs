using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace UnitTestProjectOne.PageObjectModel.DriverUtilities
{
    public class WebDriverDriverUtilities
    {
        IWebDriver driver;//null
        public WebDriverDriverUtilities(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
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
        public void EnterText(String myxpath, String text)
        {
            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath(myxpath));
            actions.MoveToElement(element).Click().SendKeys(text).Build().Perform();
        }

        public void SwitchToIframe(String myxpath)
        {
            driver.SwitchTo().Frame(ReturnElement(myxpath));
        }

        public void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
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
    }
}
