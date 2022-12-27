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
    public class LoopingStatements
    {
        //Apply color to all the steps in the building 
         // statringNumber = 1 , increase the number ,  check the numbe with the target
        //Do 101 rounds 
         //sn = 1 , increase round number , check with 101
        [TestMethod]
        public void ApplyColor()
        {
            Debug.WriteLine("Apply color to Step 1");
            Debug.WriteLine("Apply color to Step 2");
            Debug.WriteLine("Apply color to Step 3");
            Debug.WriteLine("Apply color to Step 4");
            Debug.WriteLine("Apply color to Step 5");
            Debug.WriteLine("Apply color to Step 6"); //..................600
        }
        //for(int iterator=1;iterator<maxcount;iterator=iterator+stepsize){  Redundant Task   } 
        [TestMethod]
        public void ApplyColorToSteps()
        {
            //for(int iterator=1; iterator<100; iterator = iterator+1) // 1<100 -> true ......98<100->true 99<100->true   100<100 ->false
            for (int iterator = 1; iterator <= 100; iterator = iterator + 1)  //99<=100->t , 100<=100->t
            { //true
                Debug.WriteLine("Apply color to Step :"+ iterator); //iterator = 1 2 
            }
        }
        [TestMethod]
        public void ApplyColorToEvenSteps()
        {
            for (int i = 2; i <= 100; i = i + 2)  //99<=100->t , 100<=100->t
            { //true
                Debug.WriteLine("Apply GREEN Color to Step :" + i); //iterator = 1 2 
            }
        }
        [TestMethod]
        public void ApplyColorToOddSteps()
        {
            for (int i = 1; i <= 100; i = i + 2)  //99<=100->t , 100<=100->t
            { //true
                Debug.WriteLine("Apply RED Color to Step :" + i); //iterator = 1 2 
            }
        }
        [TestMethod]
        public void WaitForYourFriendInRailwayStation()
        {
            int timeHeComes = 30;
            for(int t=1;t<=180;t=t+1)
            {
                Debug.WriteLine("Count up Timer :" + t );
                Debug.WriteLine("Wait for My Friend");
                if (t== timeHeComes)
                {
                    Debug.WriteLine("Stop Waiting and go home");
                    break;
                }               
            }
        }
        [TestMethod]
        public void FindStudent()
        {
            Boolean result = false;
            for(int i=1;i<=10;i++)
            {
                Debug.WriteLine("Student Num Searched :" + i);
                if(i==15)
                {                    
                    result = true;
                    break;
                }               
            }
            if(result==true)
            {
                Debug.WriteLine("Found the Student");
            }
            else
            {
                Debug.WriteLine("Not Found the Student");
            }
        }
        [TestMethod]
        public void FindStudent_Test()
        {
           Boolean output =  FindStudent(22);
            if (output == true)
            {
                Debug.WriteLine("Found the Student and give him a Book");
            }
            else
            {
                Debug.WriteLine("Not Found the Student");
            }
        }
        public Boolean FindStudent(int rollNum)
        {
            Debug.WriteLine("You are Searching for Student Num  :" + rollNum);
            Boolean result = false;
            for (int i = 1; i <= 100; i++)
            {
                //Debug.WriteLine("Student Num Searched :" + i);
                if (i == rollNum)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
       
        //break statement will skip the complete for loop / exit from for loop
        //continue will skip one particular iteration     

        //  a / b  : Q    ,     a % b -> R

        //Logic for even number : if the given number is divisible by 2 that number is even
        [TestMethod]
        public void GenerateEvenNumbers()
        {
            for(int i=1;i<=100;i++)
            {
                if((i%2) == 0)
                {
                    Debug.WriteLine("Even Number :" + i);
                }
            }
        }
        [TestMethod]
        public void GenerateOddNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (!((i % 2) == 0))
                {
                    Debug.WriteLine("Odd Number :" + i);
                }
            }
        }
        //Apply color to all 100 steps excluding the steps multiples of 10 [ 10 , 20 , 30 ...]
        [TestMethod]
        public void ApplyColorByExcluding10Multiples()
        {
            for(int i=1;i<=100;i++)
            {
                if((i%10) == 0)
                {
                    Debug.WriteLine("Excluding this Step :" + i);
                    Debug.WriteLine("Apply RED Color To Step :" + i);
                    continue; //skip the iteration
                }
                Debug.WriteLine("Apply Green Color To Step :" + i);
            }
        }
        [TestMethod]
        public void ApplyColorWithDoWhile()
        {
            int i = 1;
            do
            {
                //Activity
                Debug.WriteLine("Apply Green Color To Step :" + i);
                i++;
            }
            while (i <= 100);
        }

        [TestMethod]
        public void ApplyColorWithWhile()
        {
            int i = 1;
            while (i <= 100) 
            {
                //Activity
                Debug.WriteLine("Apply Green Color To Step :" + i);
                i++;
            }            
        }

        //Nested for Loop  [ For Loop inside For Loop]
        //We have Building with 10 floors , apply different color to different floor 
        [TestMethod]
        public void NestedForLoop()
        {
            for(int i=1;i<=10;i++) //Here i value will be used to count FLOOR numbers 
            {
                Debug.WriteLine("****************Apply Color To Steps in FLOOR NUMBER :" + i);
                //in first fllor start from 1st step go till 20th step and apply color
                for(int j=1;j<=20;j++)
                {
                    Debug.WriteLine("Apply Color To Step :" + j);
                }
                
            }
        }












    }
}
