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
    public class TestScenarios_M2_Child2 : RComponents_Parent
    {
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
