using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProjectOne.PageObjectModel.DriverUtilities;

namespace UnitTestProjectOne.PageObjectModel.GeneralUtilities
{
    public class Base
    {
        public ConfigData configData;
        public UserData userData;
        public IWebDriver driver;
        public WebDriverDriverUtilities dUtils;
        public Base()
        {
            configData = new ReadConfigData().ReadConfig();
            userData = new ReadJsonData().ReadTestData(configData.Environment);
            driver = new DriverSetup().GetDriver(configData.Browser);
            dUtils = new WebDriverDriverUtilities(driver);
        }
    }
}
