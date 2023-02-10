using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProjectOne.PageObjectModel.GeneralUtilities;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class Login
    {
        IWebDriver driver;//null
        UserData userData;
        public Login(IWebDriver mydriver) //1234
        {
            driver = mydriver; //1234
            userData = new ReadJsonData().ReadTestData("Dev");
        }
        public void LaunchApplication()
        {
            Debug.WriteLine("RC : LaunchApplication ");
           // driver.Navigate().GoToUrl("https://www.apsrtconline.in/");
            driver.Navigate().GoToUrl(userData.URL);
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
