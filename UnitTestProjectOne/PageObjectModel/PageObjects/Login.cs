using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class Login
    {
        IWebDriver driver;//null
        public Login(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
        }
        public void LaunchApplication()
        {
            Debug.WriteLine("RC : LaunchApplication ");
            //driver.Navigate().GoToUrl("https://www.apsrtconline.in/");
        }
        public void LogoutFromApplication()
        {
            Debug.WriteLine("RC : LogoutFromApplication ");
        }
        public void LoginToApplication()
        {
            Debug.WriteLine("RC : LoginToApplication ");
        }
        public void CloseApplication()
        {
            Debug.WriteLine("RC : CloseApplication ");
        }
    }
}
