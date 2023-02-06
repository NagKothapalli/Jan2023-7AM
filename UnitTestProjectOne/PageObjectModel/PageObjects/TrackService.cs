using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProjectOne.PageObjectModel.DriverUtilities;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class TrackService
    {

        IWebDriver driver;//null
        WebDriverDriverUtilities dUtils;
        public TrackService(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
            dUtils = new WebDriverDriverUtilities(driver); //1234
        }
        //**********************************XPATHS*************************
        String TrackServiceTab = "//a[@title='Track Service']"; 
        String ServiceNoTxt = "//input[@name='serviceCode']";
        String TrackBusBtn = "//input[@name='TrackBusBtn']";
        public void NavigateToTrackService()
        {
            Debug.WriteLine("RC : NavigateToTrackService ");
            dUtils.ClickElement(TrackServiceTab);
        }

        public void TrackServiceOfBusTicket()
        {
            Debug.WriteLine("RC : TrackServiceOfBusTicket ");
            dUtils.EnterText(ServiceNoTxt, "4455");
            dUtils.ClickElement(TrackBusBtn);
        }
    }
}
