using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectOne.PageObjectModel.TestCases;

namespace UnitTestProjectOne.PageObjectModel.TestSuites
{
    [TestClass]
    public class TestSuites
    {
        TestScenarios testScenarios = new TestScenarios();
        [TestMethod]
        public void SmokeSuite()
        {
            Debug.WriteLine("Test Suite : SMOKE ");
            testScenarios.BookBusTicketAndCancel();
            testScenarios.BookBusTicketAndCheckStatus();
        }
        [TestMethod]
        public void RegressionSuite()
        {
            Debug.WriteLine("Test Suite : REGRESSION ");
            testScenarios.BookBusTicketAndCancel();
            testScenarios.BookBusTicketAndCheckStatus();
            testScenarios.BookBusTicketAndPrint();
            testScenarios.BookBusTicketAndTrackService();
            testScenarios.BookBusTicketPrintAndCheckStatus();
        }
    }
}
