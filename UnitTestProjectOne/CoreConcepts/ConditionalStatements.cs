using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectOne.CoreConcepts
{
    //  Task

    [TestClass]
    public class ConditionalStatements
    {
        //Write a program to perform sum of two numbers
        [TestMethod]
        public void SumOfTwoNumbers()
        {
           int sum = 22 + 44;
            Debug.WriteLine("Sum of two numbers : sum");
            Debug.WriteLine("Sum of two numbers :" + sum);
        }
        //Write a program to perform sum of two numbers if they are equal
        //Task - Addition
        //if(Expression -> boolean : true / false){ true - Task } 
        [TestMethod]
        public void SumOfTwoNumber_Equal()
        {
            int Num1 = 45; //Assignment operator
            int Num2 = 45;
            if(Num1 == Num2) // == Relational operator
            { //true
                //Task
               int sum = Num1 + Num2;
               Debug.WriteLine("Sum of two numbers :" + sum);
            }
            //false
        }
        //Write a program to perform sum of two numbers if they are equal if not do subtraction
        [TestMethod]
        public void SumOfTwoNumber_IfElse()
        {
            int Num1 = 65; //Assignment operator
            int Num2 = 65; //Hard coded value
            Debug.WriteLine("First Number :" + Num1);
            Debug.WriteLine("Second Number :" + Num2);
            if (Num1 == Num2) // == Relational operator
            { //true
              //Task
                int sum = Num1 + Num2;
                Debug.WriteLine("Sum of two numbers :" + sum);
            }
            else
            {//false
                int diff = Num1 - Num2;
                Debug.WriteLine("Difference of two numbers :" + diff);
            }            
        }
    }
}
