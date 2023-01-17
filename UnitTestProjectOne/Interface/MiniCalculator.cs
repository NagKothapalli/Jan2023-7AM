using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectOne.Interface
{
    public class MiniCalculator : IAirthmeticOperations // :ScienticOPeration,TrigonmetricOperations
    {
        public int Addition(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public void DisplayLogo()
        {
            Debug.WriteLine("Welcome to CASIO Mini Calculator");
        }
        public void SwitchOff()
        {
            Debug.WriteLine("Switch OFF CASIO Mini Calculator");
        }
        public void SwitchOn()
        {
            Debug.WriteLine("Switch ON CASIO Mini Calculator");
        }

        public int Division(int a, int b)
        {
            int div = a / b;
            return div;
        }

        public int Multiplication(int a, int b)
        {
            int prod = a * b;
            return prod;
        }

        public int Subtraction(int a, int b)
        {
            int diff = a - b;
            return diff;
        }
    }
}
