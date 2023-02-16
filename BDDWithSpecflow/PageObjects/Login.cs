using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BDDWithSpecflow.PageObjects
{
    public class Login
    {
        public void LaunchApplication(string url)
        {
            Debug.WriteLine("Launch the Application :" + url);
        }
        public void LoginToApplication(string un,string pw)
        {
            Debug.WriteLine("Enter User Name  :" + un);
            Debug.WriteLine("Enter PassWord  :" + pw);
        }
        public void ValidateUserLogin()
        {
            Debug.WriteLine("User Login is Successfull");
        }
    }
}
