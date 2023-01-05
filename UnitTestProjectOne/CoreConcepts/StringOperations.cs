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
        String c = "  Selenium with CSharp           ";
        [TestMethod]
        public void BasicOperations()
        {
            int len = a.Length;
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
            if (a.Trim().ToUpper().Contains(b.Trim().ToUpper()))
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
            string[] myArr = a.Trim().Split(' ');
            Debug.WriteLine("Technology :" + myArr[2]);
        }
        [TestMethod]
        public void StringSubString()
        {
            string a8 = a.Trim().Substring(8);
            Debug.WriteLine("string from 8th :" + a8);
            string a84 = a.Trim().Substring(8, 4);
            Debug.WriteLine("substring a84 :" + a84);

        }
        //equals , equalsByIgnoringCase , read char
        //Both of them must be Strings , same in length , same in case , same in character sequence
        [TestMethod]
        public void StringComparisionWithEquals()
        {
            //Boolean  result = a.Equals(c);
            //string aUT = a.ToUpper().Trim();
            //string cUT = c.ToUpper().Trim();
            //Boolean result = a.ToUpper().Trim().Equals(c.ToUpper().Trim());
            //Boolean result = aUT.Equals(cUT);
            //if (result == true)
            //if(result)
            //if(aUT.Equals(cUT))
            if (a.ToUpper().Trim().Equals(c.ToUpper().Trim()))
            {
                Debug.WriteLine("Both the strings are equal");
            }
            else
            {
                Debug.WriteLine("Both the strings are not equal");
            }
        }
        [TestMethod]
        public void StringComparisionWithEqualsIgnoreCase()
        {
            if(a.Trim().Equals(c.Trim(),StringComparison.OrdinalIgnoreCase))
            {
                Debug.WriteLine("Both the strings are equal");
            }
            else
            {
                Debug.WriteLine("Both the strings are not equal");
            }
        }
        [TestMethod]
        public void ReadCharacters()
        {
            //           0 1 2 3 .........
            String a = "    Selenium with Csharp         ";
            char mychar = a.Trim().ElementAt(0);
            //Debug.WriteLine("Char at 0 :" + mychar);
            //Debug.WriteLine(a.Trim()[6]);
            for(int i=0;i<a.Length;i++)
            {
                Debug.WriteLine(a.ElementAt(i));
                Debug.WriteLine("---");
                Debug.WriteLine(a[i]);
            }
        }
        //Write a program to find a particular char in the string 
        //Write a program to find count of given char in the string
        //Find how many duplicate characters are there in the string 
        //WAP to reverse the given string
        //WAP to find given string is a palindrome or not 
        [TestMethod]
        public void FindCharacter()
        {
            bool result = false;
            char charToFind = 'y';
            String a = "    Selenium with Csharp         ";
            for(int i=0;i<a.Trim().Length;i++)
            {
                if(a.Trim().ElementAt(i) == charToFind)
                {
                    //Debug.WriteLine("Found the character ");
                    result = true;
                    break;
                }
            }
            //Outside of the for loop
            if(result)
            {
                Debug.WriteLine("Found the character :" + charToFind);
            }
            else
            {
                Debug.WriteLine("Not Found the character :" + charToFind);
            }
        }
    }
}
