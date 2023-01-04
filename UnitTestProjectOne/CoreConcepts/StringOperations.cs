using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectOne.CoreConcepts
{
    [TestClass]
    public class StringOperations
    {
        String a = "    Selenium with Csharp         ";
        String b = "CSHARP";
        [TestMethod]
        public void BasicOperations()
        {
            int len =  a.Length;
            Debug.WriteLine("String Length :" + len);
            string aT = a.Trim();
            Debug.WriteLine("String Length after trim:" + aT.Length);
            string aL = a.ToLower();
            Debug.WriteLine("String after lower :" + aL);
            string aU = a.ToUpper();
            Debug.WriteLine("String after upper :" + aU);

            string aTL = a.Trim().ToLower();
            Debug.WriteLine("String after  trim and lower :" + aTL);
            string aTU = a.Trim().ToUpper();
            Debug.WriteLine("String after trim and upper :" + aTU);
        }
        [TestMethod]
        public void StringContains()
        {
          //Boolean res =  a.Trim().ToLower().Contains(b.Trim().ToLower());
          //  if(res == true)
            if(a.Trim().ToUpper().Contains(b.Trim().ToUpper()))
            {
                Debug.WriteLine("String  A contains B");
            }
            else
            {
                Debug.WriteLine("String  A does not contains B");
            }
        }
        [TestMethod]
        public void StringSplit()
        {
          string[] myArr =  a.Trim().Split(' ');
          Debug.WriteLine("Technology :" + myArr[2]);
        }
        [TestMethod]
        public void StringSubString()
        {
          string  a8 =  a.Trim().Substring(8);
            Debug.WriteLine("string from 8th :" + a8);
            string a84 = a.Trim().Substring(8, 4);
            Debug.WriteLine("substring a84 :" + a84);
            
        }
        //equals , equalsByIgnoringCase , read char
    }
}
