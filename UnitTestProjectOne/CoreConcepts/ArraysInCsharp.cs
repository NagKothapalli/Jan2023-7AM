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
        //Fixed Array - size will be fixed and values are also fixed
        //Dynamic Array - Size will be fixed and values can be loaded in run time [dynamically]

        //Signature : Fixed Array
        //Modifier[opt]    DataType[]    Name = { values } ;
        //Operations : Declaration , Assignment , size , Read , Write

        //System.IndexOutOfRangeException: Index was outside the bounds of the array.
        public int   number  = 22;
        public int[] numbers = { 12, 22, 24, 27, 28, 12, 23 };
        [TestMethod]
        public void FixedIntegerArray()
        {
            //index    -      0  1   2    3   4   5     6   7   8   9   10  11   -> 12
            int[] numbers = { 5, 67, 23, 768, 34, 678, 324, 56, 34, 55, 45, 56 };
            int size = numbers.Length;
            Debug.WriteLine("Length of the Array :" + size);
            int value1 = numbers[0];
            Debug.WriteLine("Element at 0th :" + value1);
            int value2 = numbers[11];
            Debug.WriteLine("Element at 11th :" + value2);
            int value3 = numbers[4];
            Debug.WriteLine("Element at 4th :" + value3);
        }
    }
}
