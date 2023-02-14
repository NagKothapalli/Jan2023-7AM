using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProjectOne.PageObjectModel.DriverUtilities;
using UnitTestProjectOne.PageObjectModel.GeneralUtilities;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class Login
    {
        IWebDriver driver;//null
        UserData userData;
        WebDriverDriverUtilities dUtils;
        public Login(Base mybase) //1234
        {
            driver = mybase.driver; //1234
            dUtils = mybase.dUtils; //1234
            userData = mybase.userData;
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
