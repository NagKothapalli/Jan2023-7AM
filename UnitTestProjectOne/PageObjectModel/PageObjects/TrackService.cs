using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProjectOne.PageObjectModel.DriverUtilities;
using UnitTestProjectOne.PageObjectModel.GeneralUtilities;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class TrackService
    {

        IWebDriver driver;//null
        WebDriverDriverUtilities dUtils;
        UserData userData;
        public TrackService(Base mybase) //1234
        {
            driver = mybase.driver; //1234
            dUtils = mybase.dUtils; //1234
            userData = mybase.userData;
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
            dUtils.EnterText(ServiceNoTxt, userData.ServiceNumber);
            dUtils.ClickElement(TrackBusBtn);
        }
    }
}
