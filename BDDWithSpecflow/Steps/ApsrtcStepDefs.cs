using System;
using System.Collections.Generic;
using System.Text;
using BDDWithSpecflow.Hooks;
using TechTalk.SpecFlow;
using UnitTestProjectOne.PageObjectModel.GeneralUtilities;
using UnitTestProjectOne.PageObjectModel.PageObjects;

namespace BDDWithSpecflow.Steps
{
    [Binding]
    public class ApsrtcStepDefs
    {
        private readonly ScenarioContext _scenarioContext;
        Login login ;
        Base mybase;
        Home home;
        TrackService trackService;
        CancelTicket cancelTicket;
        public ApsrtcStepDefs(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            mybase = new Base();
            login = new Login(mybase);
            home = new Home(mybase);
            trackService = new TrackService(mybase);
            cancelTicket = new CancelTicket(mybase);
        }
        [Given(@"User Launched Apsrtc Application")]
        public void GivenUserLaunchedApsrtcApplication()
        {
            login.LaunchApplication();
        }

        [When(@"User Fills Ticket Details")]
        public void WhenUserFillsTicketDetails()
        {
            home.BookTicket();
        }

        [Then(@"User Could able to book the ticket")]
        public void ThenUserCouldAbleToBookTheTicket()
        {
            MyHooks.test.Log(AventStack.ExtentReports.Status.Pass, "User Booked Ticket", null);
        }

        [When(@"User Track the Service With Ticket Number")]
        public void WhenUserTrackTheServiceWithTicketNumber()
        {
            trackService.NavigateToTrackService();
            trackService.TrackServiceOfBusTicket();
            MyHooks.test.Log(AventStack.ExtentReports.Status.Info, "User Tracked the Service", null);
        }

        [Then(@"User Could able to track the service")]
        public void ThenUserCouldAbleToTrackTheService()
        {
            MyHooks.test.Log(AventStack.ExtentReports.Status.Pass, "Track Service", null);
        }
        [When(@"User Cancel the ticket With Ticket Number")]
        public void WhenUserCancelTheTicketWithTicketNumber()
        {
            cancelTicket.NavigateToCancelTicket();
            cancelTicket.CancelBusTicket();
            MyHooks.test.Log(AventStack.ExtentReports.Status.Info, "User Cancel the Bus Ticket", null);
        }

        [Then(@"User Could able to Cancel the ticket")]
        public void ThenUserCouldAbleToCancelTheTicket()
        {
            MyHooks.test.Log(AventStack.ExtentReports.Status.Pass, "Cancel Bus Ticket", null);
        }


    }
}
