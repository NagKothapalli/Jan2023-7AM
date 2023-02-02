using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class Login
    {
        public void LaunchApplication()
        {
            Debug.WriteLine("RC : LaunchApplication ");
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
