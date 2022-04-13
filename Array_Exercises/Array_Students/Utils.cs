using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Students
{
    internal class Utils
    {
        public static string ReadString(string prompt)
        {

            string s;
            while (true)
            {
                Console.Write(prompt);
                s = Console.ReadLine();
                if (s == null || s.Trim().Length == 0)
                {
                    Console.WriteLine("You should not enter an empty string.\n" +
                        "Please try again.");
                }
                else
                {
                    break;
                }
            }
            return s;
        }

        public static char ReadChar(string prompt)
        {
            string s = ReadString(prompt);
            return s[0];
        }

        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong format. You should enter a whole number.");
                }
            }
        }

        public static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong format. You should enter a number.");
                }
            }
        }
    }
}
