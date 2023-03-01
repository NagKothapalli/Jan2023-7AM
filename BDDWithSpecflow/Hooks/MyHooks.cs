using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Reporter;
using BDDWithSpecflow.PageObjects;
using TechTalk.SpecFlow;

namespace BDDWithSpecflow.Hooks
{
    [Binding]
    public class MyHooks
    {
        private readonly ScenarioContext _scenarioContext;
        Login login = new Login();
        public static ExtentTest test;
        public static ExtentReports extent;
        public MyHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
           
        }
        [Given(@"User Cleared the temp Records")]
        public void GivenUserClearedTheTempRecords()
        {
            Debug.WriteLine("User Cleared the Temp Records - Background");
        }
        [BeforeTestRun]
        public static void BeforeEntireTest()
        {
            Debug.WriteLine("Before all Feature Files");
        }
        public static string reportFilePath;
        [BeforeFeature]
        public static void LaunchApplication()
        {
            extent = new ExtentReports();  //Root object
            reportFilePath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\netcoreapp3.1\", @"\") + "Reports\\Report.html";
            //reportFilePath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\netcoreapp3.1\", @"\") + "Reports\\Report" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html";
            Debug.WriteLine("My Report File path : " + reportFilePath);
            var htmlreporter = new ExtentHtmlReporter(reportFilePath);
            extent.AttachReporter(htmlreporter);
            extent.AddSystemInfo("OS", "Windows");
            extent.AddSystemInfo("Host Name", "NagKothapalli");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("UserName", "NagK");
            Debug.WriteLine("User Launched Gmail Application - by feature hook ");
        }
        //scoped Hooks
        [BeforeScenario("smoke")]
        public void LoginToApplication()
        {
            Debug.WriteLine(_scenarioContext.ScenarioInfo.Title + "   :  Scenario Started");
            test = extent.CreateTest(_scenarioContext.ScenarioInfo.Title).Info(_scenarioContext.ScenarioInfo.Title);
            Debug.WriteLine("User Logged in to Gmail Application - by scenario hook");
           
        }
        [AfterScenario]
        public void LogoutFromApplication()
        {
            Debug.WriteLine("User Logged in to Gmail Application - by scenario hook");
            Debug.WriteLine(_scenarioContext.ScenarioInfo.Title + "   :  Scenario Completed");         
        }
        [AfterFeature]
        public static void CloseApplication()
        {
            string reportFilePathOld = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\netcoreapp3.1\", @"\") + "Reports\\index.html";          
            string reportFilePathNew = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\netcoreapp3.1\", @"\") + "Reports\\Apsrtc-"+ new Random().Next(00000, 99999) + ".html";
            
            Debug.WriteLine("User Launched Gmail Application - by feature hook ");
            extent.Flush();
            System.IO.File.Move(reportFilePathOld, reportFilePathNew);
        }
      //  F:\GE-WorkSpace\Jan2023-7AM\BDDWithSpecflow\netcoreapp3.1\PageObjectModel\TestData\Config.json'.

  
    }
}
