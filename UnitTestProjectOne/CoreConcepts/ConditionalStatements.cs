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
        //Duplicate Function : If the Name and the input parameters are same .
        [TestMethod]
        public void SumOfTwoNumber_IfElse_Test() //This is a unit test for the below funnction
        {
            SumOfTwoNumber_IfElse(44,44); // Lines Covered / Total Lines  * 100 = 5/10
            SumOfTwoNumber_IfElse(84, 44);
        }
        public void SumOfTwoNumber_IfElse(int Num1,int Num2) //Dev code written by Dev team
        {
            //int Num1 = 65; //Assignment operator
            //int Num2 = 65; //Hard coded value
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
        //Write a program to read two numbers as inputs 
        //perform sum of two numbers if they are equal,subtraction if a > b , multiplication a < b
        [TestMethod]
        public void MultipleDecisions_Test()
        {
            MultipleDecisions(66, 66); //33.333
            MultipleDecisions(646, 66);
            MultipleDecisions(66, 86);
        }
        public void MultipleDecisions(int Num1, int Num2) //Dev code written by Dev team
        {
            //int Num1 = 65; //Assignment operator
            //int Num2 = 65; //Hard coded value
            Debug.WriteLine("First Number :" + Num1);
            Debug.WriteLine("Second Number :" + Num2);
            if (Num1 == Num2) // == Relational operator
            { //true
              //Task
                int sum = Num1 + Num2;
                Debug.WriteLine("Sum of two numbers :" + sum);
            }
            else if(Num1 > Num2)
            {
                int diff = Num1 - Num2;
                Debug.WriteLine("Difference of two numbers :" + diff);
            }
            else if(Num1 < Num2)
            {
                int prod = Num1 * Num2;
                Debug.WriteLine("Product of two numbers :" + prod);
            }
        }
        //Write a program to read two numbers as inputs and do the task if and only if both numbers are above 10
        //Task : Perform sum of two numbers if they are equal,subtraction if a > b , multiplication a < b
        [TestMethod]
        public void LogicalOperators_Test()
        {
            LogicalOperators(5,8);
            LogicalOperators(55, 8);
            LogicalOperators(5, 78);
            LogicalOperators(55, 68);
            LogicalOperators(55, 55);
            LogicalOperators(75, 28);
        }
        public void LogicalOperators(int Num1,int Num2)
        {
            Debug.WriteLine("First Number :" + Num1);
            Debug.WriteLine("Second Number :" + Num2);
            //     T            T   -> T  ,  TF , FT , FF -> F
            if((Num1>10) && (Num2>10)) //Nested if condition  //Logical operator
            {
                //Task
                if (Num1 == Num2) // == Relational operator
                { //true
                  //Task
                    int sum = Num1 + Num2; // = Assignment operator
                    Debug.WriteLine("Sum of two numbers :" + sum);
                }
                else if (Num1 > Num2) // > , == , < : Relational operators
                {
                    int diff = Num1 - Num2; // + , - , * : Arithmetic Operators
                    Debug.WriteLine("Difference of two numbers :" + diff);
                }
                else if (Num1 < Num2)
                {
                    int prod = Num1 * Num2;
                    Debug.WriteLine("Product of two numbers :" + prod);
                }
            }
            else
            {
                Debug.WriteLine("Both inputs  or any one of them might be below 10");
            }

        }














    }
}
