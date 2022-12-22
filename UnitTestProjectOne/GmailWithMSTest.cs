using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectOne
{
    [TestClass]
    public class GmailWithMSTest
    {
        /// <summary>
        /// Modifier     ReturnType  Name(){    body       }
        /// </summary>
        [TestMethod]   //@Test
        public  void ComposeAndSendAnEmail() // 0 0 
        {
            //Debug.WriteLine("Login to Application - Debug ");
            Console.WriteLine("Test Case : Compose And Send An Email - Console");
            Debug.WriteLine("Test Case : Compose And Send An Email - Debug ");
        }
        [TestMethod]  // ifcondition   , ifelse  , elseif , switchcase , nestedif 
        public  void ReplyToAnEmail() // 0 0 
        {
            //Debug.WriteLine("Login to Application - Debug ");
            Console.WriteLine("Test Case : Reply to An Email - Console");
            Debug.WriteLine("Test Case : Reply to An Email - Debug ");
        }
        [TestMethod]
        public  void ForwardAnEmail() // 0 0 
        {
            //Debug.WriteLine("Login to Application - Debug ");
            Console.WriteLine("Test Case : Forward An Email - Console");
            Debug.WriteLine("Test Case : Forward An Email - Debug ");
        }
        [TestMethod]
        public  void DeleteAnEmail() // 0 0 
        {
            //Debug.WriteLine("Login to Application - Debug ");
            Console.WriteLine("Test Case : Delete An Email - Console");
            Debug.WriteLine("Test Case : Delete An Email - Debug ");
        }

        [TestInitialize]   //@Before
        public void Login()
        {
            Debug.WriteLine("Login to Application - Debug - From Intialize ");
        }
        [TestCleanup] //@After
        public void Logout()
        {
            Debug.WriteLine("Logout From Application - Debug - From Intialize ");
        }

        public void Addition()
        {

        }
         void Addition(String x)
        {

        }
        public void Addition(int num)
        {

        }

        public void Addition(int a,int b)
        {

        }
        public void Addition(int a, int b,int c)
        {

        }


    }
}
