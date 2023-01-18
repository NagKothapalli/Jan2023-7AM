using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleAppOne
{
    //Modifier[opt]   class   Name{  body   }
    public class Program
    {
        //Body  - Members ->  variables  / functions

        //Modifier[opt]    DataType    Name ;  ->Declaration           //Modifier[opt]    DataType    Name  =  value; ->Assignment

        //student -> rollnum , percentge ,  grade , result , name , collegeName

        public static int stdNumber = 22; //rice bag - 20 Kg capacity

        public long population = 2275676577677657;

        private double percentage = 88.56;

        internal char grade = 'A';  //a to z -> a b c d e f g h i .... 26

        protected Boolean result = true;  //true false

        string stdName = "Ram";    // Typemismatch error

        public static string collegeName = "JNTU";

        public long number = stdNumber; //TypeCasting ->Implicit typecasting , Widening



        //Modifier[opt]    ReturnType    Name(){  body }
        //Modifier[opt]    ReturnType    Name(arguments...[opt]){  body }
        // 0 0 , 0 1 , 1 0 , 1 1
        //no o/p - no i/p ,  no o/p -  i/p
        //psvm
        //Program myprogram = new Program();
        //myprogram.
        public static void Main(String[] inputs)
        {
            Console.WriteLine("Welcome to Selenium with C# - Console");
            Debug.WriteLine("Welcome to Selenium with C# - Debug ");
            //comment ->//
            //group comment -> CTRL+K+C
            //group un-comment -> CTRL+K+U
            //return 22;
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://gmail.com");
            driver.FindElement(By.Id("identifierId")).SendKeys("nag022");
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
        }
        public static void ComposeAndSendAnEmail() // 0 0 
        {
            Console.WriteLine("Test Case : Compose And Send An Email - Console");
            Debug.WriteLine("Test Case : Compose And Send An Email - Debug ");
        }

        public static void ReplyToAnEmail() // 0 0 
        {
            Console.WriteLine("Test Case : Reply to An Email - Console");
            Debug.WriteLine("Test Case : Reply to An Email - Debug ");
        }

        public static void ForwardAnEmail() // 0 0 
        {
            Console.WriteLine("Test Case : Forward An Email - Console");
            Debug.WriteLine("Test Case : Forward An Email - Debug ");
        }
        public static void DeleteAnEmail() // 0 0 
        {
            Console.WriteLine("Test Case : Delete An Email - Console");
            Debug.WriteLine("Test Case : Delete An Email - Debug ");
        }




    }
}
