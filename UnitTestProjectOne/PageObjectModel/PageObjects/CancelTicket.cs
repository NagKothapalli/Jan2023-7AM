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
    public class CancelTicket
    {
        IWebDriver driver;//null
        WebDriverDriverUtilities dUtils;
        public CancelTicket(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
            dUtils = new WebDriverDriverUtilities(driver); //1234
        }
        //**********************************XPATHS*************************
        String CancelTicketTab = "//a[@title='Cancel Ticket']";
        String TicketNoTxt = "//input[@name='id']";
        String UIDNoTxt = "//input[@name='uidNumber']";
        String MobileNumTxt = "//input[@name='mobileNo']";
        String SearchBtn = "//input[@name='searchBtn']";
        public void NavigateToCancelTicket()
        {
            Debug.WriteLine("RC : NavigateToCancelTicket ");
            dUtils.ClickElement(CancelTicketTab);
        }

        public void CancelBusTicket()
        {
            Debug.WriteLine("RC : CancelBusTicket ");
            dUtils.EnterText(TicketNoTxt, "1234665656");
            dUtils.EnterText(UIDNoTxt, "565453454");
            dUtils.EnterText(MobileNumTxt, "9959775757");
            dUtils.ClickElement(SearchBtn);
        }
    }
}
