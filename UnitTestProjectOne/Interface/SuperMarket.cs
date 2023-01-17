using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectOne.Interface
{
    [TestClass]
    public class SuperMarket
    {
        MiniCalculator mCalc = new MiniCalculator();
        IAirthmeticOperations aCalc = new MiniCalculator();
        //IWebDriver driver = new IWebDriver();  x not allowed
        //ChromeDriver driver = new ChromeDriver();
        //IWebDriver driver = new FirefoxDriver();
        [TestMethod]
        public void CustomerBill()
        {
            mCalc.SwitchOn();
            mCalc.DisplayLogo();
            int prod1 = 123333;
            int prod2 = 1675544;
            int bill = mCalc.Addition(prod1, prod2);
            Debug.WriteLine("Customer Bill :" + bill);
            mCalc.SwitchOff();
        }

        public void CustomerBill_2()
        {
            aCalc.Addition(34, 45);
        }
    }
}
