using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDWithSpecflow.Hooks
{
    [Binding]
    public class MyHooks
    {
        [Given(@"User Cleared the temp Records")]
        public void GivenUserClearedTheTempRecords()
        {
            Debug.WriteLine("User Cleared the Temp Records - Background");
        }

        [BeforeFeature]
        public static void LaunchApplication()
        {
            Debug.WriteLine("User Launched Gmail Application - by feature hook ");
        }
        [BeforeScenario]
        public void LoginToApplication()
        {
            Debug.WriteLine("User Logged in to Gmail Application - by scenario hook");
        }
    }
}
