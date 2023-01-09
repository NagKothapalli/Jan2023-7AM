using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectOne.MultilevelInheritance
{
    [TestClass]
    //       A  : B : C -> A:C[Indirectly]
    //    TestSuites[GrandChild]  : TestScenarios[ImmediateParent] : RComponents[GrandParent]
    //            child          parent

    public class TestSuites : TestScenarios
    {
        // Ctrl+K+C -> Comment group of lines - Ctrk+K+U -> UnComment
        // Ctrl + Shift + /  -> Group Comment and UnComment
        /*public void LaunchApplication()
        {
            Debug.WriteLine("Launch the Application -From TestSuites ");
        }*/

        [TestMethod]
        public void SmokeSuite()
        {
            LaunchApplication();
            //Debug.WriteLine("Test Suite : SMOKE ");
            //ComposeAndSendAnEmail();
            //ReplyToAnEmail();
        }
        [TestMethod]
        public void RegressionSuite()
        {
            Debug.WriteLine("Test Suite : REGRESSION ");
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
        }
    }
}
