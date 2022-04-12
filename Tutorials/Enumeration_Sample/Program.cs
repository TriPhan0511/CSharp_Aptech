using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_Sample
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int green = (int)Color.Green;
        //    int yellow = (int)Color.Yellow;
        //    Console.WriteLine($"Value of Green: {green}");
        //    Console.WriteLine($"Value of Yellow: {yellow}");
        //    //Value of Green: 1
        //    //Value of Yello: 2
        //}

        static void Main(string[] args)
        {
            Fruit orange = new Fruit() { Name = "Orange", Color = Color.Yellow };
            Console.WriteLine(orange);

            Fruit avocado = new Fruit() { Name = "Avocado", Color = Color.Green };
            Console.WriteLine(avocado);
        }
    }
}
