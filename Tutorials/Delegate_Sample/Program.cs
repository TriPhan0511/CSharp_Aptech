using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Sample
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        (new Program()).Run();
    //    }

    //    private void Run()
    //    {
    //        // Create an instance of PerformCalculation delegate
    //        // that references to Calculation.Add method.
    //        PerformCalculation addDelegate = new PerformCalculation(Calculation.Add);

    //        // Create an instance of PerformCalculation delegate
    //        // that references to Calculation.Mutiply
    //        PerformCalculation multiplyDelegate = new PerformCalculation(Calculation.Multiply);

    //        //Console.WriteLine($"5 + 3 = {addDelegate(5, 3)}");
    //        //Console.WriteLine($"5 x 3 = {multiplyDelegate(5, 3)}");

    //        PerformCalculation subtractDelegate = new PerformCalculation((new Calculation()).Subtract);
    //        Console.WriteLine($"5 - 3 = {subtractDelegate(5, 3)}");
    //    }
    //}
    //-------------------------------------------------------------------------------------------------------------

    internal class Program
    {
        public delegate void DelEventHandler();

        public static event DelEventHandler add;

        static void Main(string[] args)
        {
            add += new DelEventHandler(USA);
            add += new DelEventHandler(India);
            add += new DelEventHandler(England);

            add.Invoke();
        }

        static void USA()
        {
            Console.WriteLine("USA");
        }
        
        static void India()
        {
            Console.WriteLine("India");
        }
        
        static void England()
        {
            Console.WriteLine("England");
        }
    }
}
