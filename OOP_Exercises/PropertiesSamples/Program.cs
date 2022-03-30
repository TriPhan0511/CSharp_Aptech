using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();
            t.Hours = 15.5;

            Console.WriteLine($"Time in hours: {t.Hours}");
        }
    }
}
