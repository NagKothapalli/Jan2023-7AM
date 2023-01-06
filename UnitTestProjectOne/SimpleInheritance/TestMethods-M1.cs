using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectOne.SimpleInheritance
{
    [TestClass]
    //              Child             Parent
    public class TestMethods_M1 : ReusableComponents
    {
        [TestMethod]   //@Test
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
        [TestMethod]
        public void ForwardAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Forward An Email - Debug ");
            LaunchApplication();
            LoginToApplication();
            Open();
            Forward();
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]
        public void DeleteAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Delete An Email - Debug ");
            LaunchApplication();
            LoginToApplication();
            Open();
            Delete();
            LogoutFromApplication();
            CloseApplication();
        }
    }
}
