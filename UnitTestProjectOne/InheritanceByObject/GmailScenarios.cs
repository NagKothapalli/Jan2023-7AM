using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectOne.InheritanceByObject
{
    [TestClass]
    public class GmailScenarios
    {
        //Modifier[opt]  ClassName  objectName  = new Constructor();
        //public GmailRComponents gmailRComponents = new GmailRComponents();//default constructor
        //public GmailRComponents gmailRComponents = new GmailRComponents("firefox");
        public GmailRComponents gmailRComponents = new GmailRComponents("firefox",106);
        //Execution Flow : Class Variables -> Constructor of the class -> Test Intialize -> Test Method
        [TestMethod]   //@Test
        public void ComposeAndSendAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Compose And Send An Email - Debug ");
            gmailRComponents.LaunchApplication();
            gmailRComponents.LoginToApplication("nag");
            gmailRComponents.Compose();
            gmailRComponents.Send();
            gmailRComponents.LogoutFromApplication();
            gmailRComponents.CloseApplication();
        }
        [TestMethod]  // ifcondition   , ifelse  , elseif , switchcase , nestedif 
        public void ReplyToAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Reply to An Email - Debug ");
            gmailRComponents.LaunchApplication();
            gmailRComponents.LoginToApplication();
            gmailRComponents.Open();
            gmailRComponents.Reply();
            gmailRComponents.LogoutFromApplication();
            gmailRComponents.CloseApplication();
        }
        [TestMethod]
        public void ForwardAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Forward An Email - Debug ");
            gmailRComponents.LaunchApplication();
            gmailRComponents.LoginToApplication();
            gmailRComponents.Open();
            gmailRComponents.Forward();
            gmailRComponents.LogoutFromApplication();
            gmailRComponents.CloseApplication();
        }
        [TestMethod]
        public void DeleteAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Delete An Email - Debug ");
            gmailRComponents.LaunchApplication();
            gmailRComponents.LoginToApplication();
            gmailRComponents.Open();
            gmailRComponents.Delete();
            gmailRComponents.LogoutFromApplication();
            gmailRComponents.CloseApplication();
        }
    }
}
