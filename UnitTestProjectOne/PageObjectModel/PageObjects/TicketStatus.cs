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
    public class TicketStatus
    {
        IWebDriver driver;//null
        WebDriverDriverUtilities dUtils;
        public TicketStatus(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
            dUtils = new WebDriverDriverUtilities(driver); //1234
        }
        //**********************************XPATHS*************************
        String TicketStatusTab = "//a[@title='Ticket Status']";
        String TicketNoTxt = "//span[contains(text(),'Track Ticket Status')]//ancestor::div[@class='subContent']//input[@name='id' and @class='searchTktCancel']";
        String SubmitBtn = "//span[contains(text(),'Track Ticket Status')]//ancestor::div[@class='subContent']//tr//td//input[@value='Submit' ]";
        public void NavigateToTicketStatus()
        {
            Debug.WriteLine("RC : NavigateToTicketStatus ");
            dUtils.ClickElement(TicketStatusTab);
        }

        public void CheckStatusOfBusTicket()
        {
            Debug.WriteLine("RC : CheckStatusOfBusTicket ");
            dUtils.EnterText(TicketNoTxt, "45435435");
            dUtils.ClickElement(SubmitBtn);
        }
    }
}
