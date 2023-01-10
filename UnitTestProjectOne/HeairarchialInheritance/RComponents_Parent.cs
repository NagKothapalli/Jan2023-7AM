using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectOne.HeairarchialInheritance
{
    public class RComponents_Parent
    {
        //******************ReusableComponents********************
        public void LaunchApplication()
        {
            Debug.WriteLine("Launch the Application -From RComponents ");
            // 10 lines of selenium code  
            //open an empty browser
            //call the application url
            //maximize the browser
            //verifiy the URL
            //verifiy the title of application
            //verify the home page
        }
        public void LoginToApplication()
        {
            Debug.WriteLine("Login to Application  ");
            // 10 lines of selenium code
        }
        //[TestCleanup] //@After
        public void LogoutFromApplication()
        {
            Debug.WriteLine("Logout From Application ");
        }
        protected void CloseApplication()
        {
            Debug.WriteLine("Close the Application ");
        }
        public void Compose()
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
        public void Forward()
        {
            Debug.WriteLine("Compose the Email ");
        }
        protected void Delete()
        {
            Debug.WriteLine("Delete the Email ");
        }
        //******************************************************
    }
}
