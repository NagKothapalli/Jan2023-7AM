using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectOne.PageObjectModel.PageObjects;

namespace UnitTestProjectOne.PageObjectModel.TestCases
{
    [TestClass]
    public class TestScenarios : Login //, Home
    {
        [TestMethod]
        public void BookBusTicketAndPrint()
        {
            Debug.WriteLine("Test Case : BookBusTicketAndPrint ");
            //launch , login , bookTicket , Print , logout , close
            LaunchApplication();
            LoginToApplication();
            //bookTicket
            //print
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]
        public void BookBusTicketAndCancel()
        {
            Debug.WriteLine("Test Case : BookBusTicketAndCancel ");
            //launch , login , bookTicket , Print , logout , close
            LaunchApplication();
            LoginToApplication();
            //bookTicket
            //print
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]
        public void BookBusTicketAndTrackService()
        {
            Debug.WriteLine("Test Case : BookBusTicketAndTrackService ");
            //launch , login , bookTicket , Print , logout , close
            LaunchApplication();
            LoginToApplication();
            //bookTicket
            //print
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]
        public void BookBusTicketAndCheckStatus()
        {
            Debug.WriteLine("Test Case : BookBusTicketAndCheckStatus ");
            //launch , login , bookTicket , Print , logout , close
            LaunchApplication();
            LoginToApplication();
            //bookTicket
            //print
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]
        public void BookBusTicketPrintAndCheckStatus()
        {
            Debug.WriteLine("Test Case : BookBusTicketPrintAndCheckStatus ");
            //launch , login , bookTicket , Print , logout , close
            LaunchApplication();
            LoginToApplication();
            //bookTicket
            //print
            LogoutFromApplication();
            CloseApplication();
        }
    }
}
