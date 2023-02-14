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
    public class CancelTicket
    {
        IWebDriver driver;//null
        WebDriverDriverUtilities dUtils;
        UserData userData;
        public CancelTicket(Base mybase) //1234
        {
            driver = mybase.driver; //1234
            dUtils = mybase.dUtils; //1234
            userData = mybase.userData;
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
            dUtils.EnterText(TicketNoTxt, userData.TicketNumber);
            dUtils.EnterText(UIDNoTxt, userData.UIDNumber);
            dUtils.EnterText(MobileNumTxt, userData.MobileNumber);
            dUtils.ClickElement(SearchBtn);
        }
    }
}
