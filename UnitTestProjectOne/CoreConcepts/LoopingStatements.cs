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
                //if()
                Debug.WriteLine("Wait for My Friend");
            }
        }

    }
}
