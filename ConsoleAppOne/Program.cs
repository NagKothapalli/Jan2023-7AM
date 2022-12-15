using System;

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




    }
}
