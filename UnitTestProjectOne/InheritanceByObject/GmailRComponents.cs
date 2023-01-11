using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectOne.InheritanceByObject
{
    public class GmailRComponents
    {
        public GmailRComponents() //Default
        {
            Debug.WriteLine("Open Google Chrome as default Browser  ");
            Debug.WriteLine("Clean the Data Base ");
        }
        public GmailRComponents(string browser)
        {
            Debug.WriteLine("Open Browser : " + browser);//if(browser)
            Debug.WriteLine("Clean the Data Base ");
        }
        public GmailRComponents(string browser,int version)
        {
            Debug.WriteLine("Open Browser : " + browser + "  , Version : "+ version  );//if(browser)
            Debug.WriteLine("Clean the Data Base ");
        }
        //******************ReusableComponents********************
        public void LaunchApplication()
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
        public void LoginToApplication()
        {
            Debug.WriteLine("Login to Application with default user details ");
            // 10 lines of selenium code
        }
        public void LoginToApplication(string username)
        {
            Debug.WriteLine("Login to Application with User as: " + username);
            // 10 lines of selenium code
        }
        public void LoginToApplication(string username,string password)
        {
            Debug.WriteLine("Login to Application with given User credentials: " + username + password);
            // 10 lines of selenium code
        }
        //[TestCleanup] //@After
        public void LogoutFromApplication()
        {
            Debug.WriteLine("Logout From Application ");
        }
        public void CloseApplication()
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
        public void Open()
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
        public void Delete()
        {
            Debug.WriteLine("Delete the Email ");
        }
        //******************************************************
    }
}
