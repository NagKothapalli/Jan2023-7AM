using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProjectOne.PageObjectModel.DriverUtilities;
using UnitTestProjectOne.PageObjectModel.GeneralUtilities;
using UnitTestProjectOne.PageObjectModel.PageObjects;

namespace UnitTestProjectOne.PageObjectModel.TestCases
{
    [TestClass]
    public class TestScenarios // : Login //, Home
    {
        //IWebDriver driver ; // null        
        Login login ;
        Home home ;
        CancelTicket cancelTicket ;
        TrackService trackService ;
        TicketStatus ticketStatus ;
        //UserData userData;
        //ConfigData configData;
        public TestScenarios(Base mybase)
        {
            //driver = new ChromeDriver(); // 1234 
            //configData = new ReadConfigData().ReadConfig();
            //userData = new ReadJsonData().ReadTestData(configData.Environment);
            //driver = new DriverSetup().GetDriver(configData.Browser);
            mybase.driver.Manage().Window.Maximize();
            login = new Login(mybase); //1234
            home = new Home(mybase); //1234
            cancelTicket = new CancelTicket(mybase); //1234
            trackService = new TrackService(mybase);//1234
            ticketStatus = new TicketStatus(mybase);
        }
       // [TestMethod]
        public void BookBusTicketAndPrint()
        {
            Debug.WriteLine("Test Case : BookBusTicketAndPrint ");
            //launch , login , bookTicket , Print , logout , close
            login.LaunchApplication();
            login.LoginToApplication();
            home.BookTicket();
            home.PrintTicket();
            login.LogoutFromApplication();
            login.CloseApplication();
        }
       // [TestMethod]
        public void BookBusTicketAndCancel()
        {
            Debug.WriteLine("Test Case : BookBusTicketAndCancel ");
            //launch , login , bookTicket , Print , logout , close
            login.LaunchApplication();
            login.LoginToApplication();
            home.BookTicket();
            cancelTicket.NavigateToCancelTicket();
            cancelTicket.CancelBusTicket();
            login.LogoutFromApplication();
            login.CloseApplication();
        }
       // [TestMethod]
        public void BookBusTicketAndTrackService()
        {
            Debug.WriteLine("Test Case : BookBusTicketAndTrackService ");
            //launch , login , bookTicket , Print , logout , close
            login.LaunchApplication();
            login.LoginToApplication();
            home.BookTicket();
            trackService.NavigateToTrackService();
            trackService.TrackServiceOfBusTicket();
            login.LogoutFromApplication();
            login.CloseApplication();
        }
       // [TestMethod]
        public void BookBusTicketAndCheckStatus()
        {
            Debug.WriteLine("Test Case : BookBusTicketAndCheckStatus ");
            //launch , login , bookTicket , Print , logout , close
            login.LaunchApplication();
            login.LoginToApplication();
            home.BookTicket();
            ticketStatus.NavigateToTicketStatus();
            ticketStatus.CheckStatusOfBusTicket();
            login.LogoutFromApplication();
            login.CloseApplication();
        }
      //  [TestMethod]
        public void BookBusTicketPrintAndCheckStatus()
        {
            Debug.WriteLine("Test Case : BookBusTicketPrintAndCheckStatus ");
            //launch , login , bookTicket , Print , logout , close
            login.LaunchApplication();
            login.LoginToApplication();
            home.BookTicket();
            home.PrintTicket();
            ticketStatus.NavigateToTicketStatus();
            ticketStatus.CheckStatusOfBusTicket();
            login.LogoutFromApplication();
            login.CloseApplication();
        }
    }
}
