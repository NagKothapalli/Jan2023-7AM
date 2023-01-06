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
            Debug.WriteLine("Test Case : Compose And Send An Email - Debug ");
            LaunchApplication();
            LoginToApplication();
            Compose();
            Send();
            LogoutFromApplication();
            CloseApplication();
        }
        [TestMethod]  // ifcondition   , ifelse  , elseif , switchcase , nestedif 
        public  void ReplyToAnEmail() // 0 0 
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
        public  void ForwardAnEmail() // 0 0 
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
        public  void DeleteAnEmail() // 0 0 
        {
            Debug.WriteLine("Test Case : Delete An Email - Debug ");
            LaunchApplication();
            LoginToApplication();
            Open();
            Delete();
            LogoutFromApplication();
            CloseApplication();
        }

        // [TestInitialize]   //@Before
        //******************ReusableComponents********************
        private void LaunchApplication()
        {
            Debug.WriteLine("Launch the Application  ");
            // 10 lines of selenium code  
            //open an empty browser
            //call the application url
            //maximize the browser
            //verifiy the URL
            //verifiy the title of application
            //verify the home page
        }
        void LoginToApplication()
        {
            Debug.WriteLine("Login to Application  ");
           // 10 lines of selenium code
        }
        //[TestCleanup] //@After
        private void LogoutFromApplication()
        {
            Debug.WriteLine("Logout From Application ");
        }
        public void CloseApplication()
        {
            Debug.WriteLine("Close the Application ");
        }
        void Compose()
        {
            Debug.WriteLine("Compose the Email ");
        }
        public void Send()
        {
            Debug.WriteLine("Send the Email ");
        }
        protected void Open()
        {
            Debug.WriteLine("Open the Email ");
        }
        public void Reply()
        {
            Debug.WriteLine("Reply to Email ");
        }
        protected void Forward()
        {
            Debug.WriteLine("Compose the Email ");
        }
        public void Delete()
        {
            Debug.WriteLine("Delete the Email ");
        }
        //******************************************************
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
