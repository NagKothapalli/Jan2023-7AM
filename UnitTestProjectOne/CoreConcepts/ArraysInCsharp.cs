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
    public class ArraysInCsharp
    {
        //Array : Group of memory locations with similar data type.
        //Fixed Array - size will be fixed and values are also fixed
        //Dynamic Array - Size will be fixed and values can be loaded in run time [dynamically]

        //Signature : Fixed Array
        //Modifier[opt]    DataType   Name =  value  ;
        //Modifier[opt]    DataType[]    Name = { values } ;
        //Operations : Declaration , Assignment , size , Read , Write

        //System.IndexOutOfRangeException: Index was outside the bounds of the array.
        public int number = 22;
        public int[] numbers = { 12, 22, 24, 27, 28, 12, 23 };
        [TestMethod]
        public void FixedIntegerArray()
        {
            //index    -      0  1   2    3   4   5     6   7   8   9   10  11   -> 12
            int[] numbers = { 5, 67, 23, 768, 34, 678, 324, 56, 34, 55, 45, 56 };
            int size = numbers.Length;
            //Debug.WriteLine("Length of the Array :" + size);
            //int value1 = numbers[0];
            //Debug.WriteLine("Element at 0th :" + value1);
            //int value2 = numbers[11];
            //Debug.WriteLine("Element at 11th :" + value2);
            //int value3 = numbers[6];
            //Debug.WriteLine("Element at 6th :" + value3);
            //numbers[6] = 44;
            //Debug.WriteLine("Element at 6th :" + numbers[6]);
            // for(int i=0;i<size;i++) // i=0....11  11<12 -> t 12<12->f
            for (int i = 0; i < size; i++) // i=0....11  11<=12 -> t 12<=12->t
            {
                Debug.WriteLine("Elements :" + numbers[i]); //i =0
            }

            for (int i = 0; i < size; i++) // i=0....11  11<=12 -> t 12<=12->t
            {
                numbers[i] = 1234 + i; // 1234+0 , 1234+1 , 1234+2 
                Debug.WriteLine("Elements after writing :" + numbers[i]); //i =0
            }
            for (int i = 0; i < size; i++) // i=0....11  11<=12 -> t 12<=12->t
            {
                numbers[i] = 1234 + numbers[i]; //  1234+5 , 1234+67 
                Debug.WriteLine("Elements after after writing :" + numbers[i]); //i =0
            }
        }
        [TestMethod]
        public void FixedStringArray()
        {
            string[] names = {"Ram","Ravi","Raj","Raju" };
            for (int i = 0; i < names.Length; i++) // i=0....11  11<=12 -> t 12<=12->t
            {
                Debug.WriteLine("Elements :" + names[i]); //i =0
            }

        }
        //Write a program to read an array as input and find even numbers
        //Write a program to read an array as input and find odd numbers
        //Write a program to read an array as input and find sum of all numbers
        //Write a program to read an array as input and find given numbers
        //Write a program to read an array as input and find sum of even numbers
        //Write a program to read an array as input and find sum of odd numbers

        //Signature : Dynamic Array  - It will be fixed in size , values will be assigned in run time
        //Modifier[opt]    DataType   Name =  value  ;
        //Modifier[opt]    DataType[]    Name = new DataType[length] ;
        //Operations : Declaration , Assignment , size , Read , Write
        [TestMethod]
        public void DynamicIntegerArray()
        {
            //index    -      0  1   2    3   4   5     6   7   8   9   10  11   -> 12
            //int[] numbers = { 5, 67, 23, 768, 34, 678, 324, 56, 34, 55, 45, 56 };
            int[] numbers = new int[10];
            int size = numbers.Length;
            for (int i = 0; i < size; i++) // i=0....11  11<=12 -> t 12<=12->t
            {
                Debug.WriteLine("Elements :" + numbers[i]); //i =0
            }
            //Default value for an integer in C# is 0

            for (int i = 0; i < size; i++) // i=0....11  11<=12 -> t 12<=12->t
            {
                numbers[i] = 1234 + i; //write // 1234+0 , 1234+1 , 1234+2 
                Debug.WriteLine("Elements after writing :" + numbers[i]);//read //i =0
            }
           
        }
        [TestMethod]
        public void DynamicStringArray()
        {
            //string[] names = { "Ram", "Ravi", "Raj", "Raju" };
            string[] names = new string[10];
            for (int i = 0; i < names.Length; i++) // i=0....11  11<=12 -> t 12<=12->t
            {
                Debug.WriteLine("Elements :" + names[i]); //i =0
            }

            for (int i = 0; i < names.Length; i++) // i=0....11  11<=12 -> t 12<=12->t
            {
                names[i] = "Selenium-"+i;
                Debug.WriteLine("Elements :" + names[i]); //i =0
            }
           
        }
    }
}
