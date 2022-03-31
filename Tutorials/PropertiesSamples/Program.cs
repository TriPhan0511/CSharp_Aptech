using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesSamples
{
    internal class Program
    {
        //// This sample demonstrates how to use properties with backing fields
        //static void Main(string[] args)
        //{
        //    TimePeriod t = new TimePeriod();
        //    t.Hours = 15.5;

        //    Console.WriteLine($"Time in hours: {t.Hours}");
        //}
        // ------------------------------------------------------------------------------------

        //// This sample demonstrates "Expression body definitions"
        //static void Main(string[] args)
        //{
        //    var person = new Person("Magnus", "Hedlund");
        //    Console.WriteLine(person.Name); // Magnus Hedlund
        //}
        // ------------------------------------------------------------------------------------

        //// This sample illustrates the use of expression body definitions for both accessors.
        //static void Main(string[] args)
        //{
        //    var saleItem = new SaleItem("Shoes", 99.99m);
        //    Console.WriteLine($"{saleItem.Name}: sells for {saleItem.Price:C2}"); // Shoes: sells for $99.99
        //}
        // ------------------------------------------------------------------------------------

        // This sample illustrates "Auto-implemented properties"
        static void Main(string[] args)
        {
            var item = new Item();
            item.Name = "Hat";
            item.Price = 10.99m;
            Console.WriteLine($"{item.Name}: sells for {item.Price:c2}"); // Hat: sells for $10.99
        }
    }
}
