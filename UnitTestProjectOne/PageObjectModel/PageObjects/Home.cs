using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProjectOne.PageObjectModel.DriverUtilities;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class Home
    {
        IWebDriver driver;//null
        WebDriverDriverUtilities dUtils;
        public Home(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
            dUtils = new WebDriverDriverUtilities(driver); //1234
        }
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
            Debug.WriteLine("RC : Book Bus Ticket ");
            dUtils.EnterText(FromCityTxt, "HYDERABAD");
            dUtils.FixedWait(1);
            dUtils.ClickEnter();
            dUtils.EnterText(ToCityTxt, "GUNTUR");
            dUtils.FixedWait(1);
            dUtils.ClickEnter();
            dUtils.ClickElement(OpenCalendarBtn);
            SelectJourneyDate("31");
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
