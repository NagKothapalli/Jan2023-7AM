using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectOne.HeairarchialInheritance
{
    [TestClass]
    public class TestScenarios_M1_Child1 : RComponents_Parent //, TestScenarios_M2_Child2
    {
        [TestMethod]
        public void ComposeAndSendAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Compose And Send An Email - Debug ");
            LaunchApplication();
            LoginToApplication();
            Compose();
            Send();
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]  // ifcondition   , ifelse  , elseif , switchcase , nestedif 
        public void ReplyToAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Reply to An Email - Debug ");
            LaunchApplication();
            LoginToApplication();
            Open();
            Reply();
            LogoutFromApplication();
            CloseApplication();
        }
       
    }
}
