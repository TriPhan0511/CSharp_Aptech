using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = Divide();
        }

        private static int Divide()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 1 / x;
            }
            catch (DivideByZeroException e)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            return div;
        }
    }
}
