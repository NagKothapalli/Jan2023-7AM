using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectOne.PageObjectModel.DriverUtilities
{
    public class WebDriverDriverUtilities
    {
        IWebDriver driver;//null
        WebDriverWait wait;
        IWebElement element;
        Actions actions;
        public WebDriverDriverUtilities(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
            actions = new Actions(driver);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        //****************Generic functions / Utility functions **************************
        public IWebElement ReturnElement(String myxpath)
        {
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(myxpath)));
            //IWebElement element = driver.FindElement(By.XPath(myxpath));
            return element;
            //actions.MoveToElement(element).Click().Build().Perform();
        }
        public void ClickElement(String myxpath)
        {
            //Actions actions = new Actions(driver);
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(myxpath)));
            //IWebElement element = driver.FindElement(By.XPath(myxpath));
            actions.MoveToElement(element).Click().Build().Perform();
        }
        public void EnterText(String myxpath, String text)
        {
            //Actions actions = new Actions(driver);
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(myxpath)));
            //IWebElement element = driver.FindElement(By.XPath(myxpath));
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
            //new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            actions.SendKeys(Keys.Enter).Build().Perform();
        }
        public void ClickTab()
        {
            actions.SendKeys(Keys.Tab).Build().Perform();
        }
        public void FixedWait(int timeInSeconds)
        {
            //Thread.Sleep(1000 * timeInSeconds);
            actions.Pause(TimeSpan.FromSeconds(timeInSeconds)).Build().Perform();
        }
    }
}
