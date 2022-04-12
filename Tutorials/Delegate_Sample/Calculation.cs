using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Sample
{
    // This delegate can reference to any method
    // which takes two integers as parameters and
    // return an integer.
    public delegate int PerformCalculation(int x, int y);

    // This class contains methods that the PerformCalculation delegate will reference to.
    internal class Calculation
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;    
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
