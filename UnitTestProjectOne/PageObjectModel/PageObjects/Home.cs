using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UnitTestProjectOne.PageObjectModel.DriverUtilities;
using UnitTestProjectOne.PageObjectModel.GeneralUtilities;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class Home
    {
        IWebDriver driver;//null
        WebDriverDriverUtilities dUtils;
        ReadJsonData readJsonData;
        UserData userData;
        public Home(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
            dUtils = new WebDriverDriverUtilities(driver); //1234
            userData = new ReadJsonData().ReadTestData("Dev");
        }
        //[FindsBy(How = How.Id, Sink = "username")] private IWebElement UserName;
        //**********************************XPATHS*************************
        String FromCityTxt = "//input[contains(@title,'Enter bording place')]";
        String ToCityTxt = "//input[contains(@title,'Enter alighting place')]";
        String OpenCalendarBtn = "//input[@name='txtJourneyDate']";
        String SearchButtonBtn = "//input[@value='Check Availability']";
        String TimeTableLink = "//a[@title='TimeTable / Track']";
        String AllServicesLink = "//a[text()='All services Time Table & Tracking']";
        //**********************************************************************
        public void BookTicket()
        {
            //Thread.Sleep(30000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.TagName("h1")));
            Debug.WriteLine("RC : Book Bus Ticket ");
            //dUtils.EnterText(FromCityTxt, "HYDERABAD");
            dUtils.EnterText(FromCityTxt, userData.FromCity);
            dUtils.FixedWait(1);
            dUtils.ClickEnter();
            dUtils.EnterText(ToCityTxt, userData.ToCity);
            dUtils.FixedWait(1);
            dUtils.ClickEnter();
            dUtils.ClickElement(OpenCalendarBtn);
            SelectJourneyDate(userData.JDate);
            dUtils.ClickElement(SearchButtonBtn);
        }
        public void PrintTicket()
        {
            Debug.WriteLine("RC : Print Bus Ticket ");
        }
        public void SelectJourneyDate(String jDate)
        {
            driver.FindElement(By.XPath("//a[text()='" + jDate + "']")).Click();
        }
    }
}
