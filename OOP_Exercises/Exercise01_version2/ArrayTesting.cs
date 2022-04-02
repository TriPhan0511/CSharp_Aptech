using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_version2
{
    internal class ArrayTesting
    {
        private PrimarySchoolStudent[] students1;
        private JuniorHighSchoolStudent[] students2;
        private HighSchoolStudent[] students3;

        public static void DisplayOptions()
        {
            char choice;
            do
            {
                // Menu options
                Console.WriteLine("\n-----Welcome to Student Management Application!-----\n");
                Console.WriteLine("1. Create an array of primary school students");
                Console.WriteLine("2. Create an array of junior high school students");
                Console.WriteLine("3. Create an array of high school students");
                Console.WriteLine("4. Display the array containing the primary school students");
                Console.WriteLine("5. Display the array containing the junior high school students");
                Console.WriteLine("6. Display the array containing the high school students");
                Console.WriteLine("7. Exit");
                choice = ReadChar("Enter your choice: ");
                switch (choice)
                {
                    case '1':
                        Console.Write("One");
                        break;
                    case '2':
                        Console.Write("Two");
                        break;
                    case '3':
                        Console.Write("Three");
                        break;
                    case '4':
                        Console.Write("Four");
                        break;
                    case '5':
                        Console.Write("Goodbye");
                        break;
                    default:
                        Console.Write("Wrong choice.");
                        break;
                }
            } while (choice != '7');

            
        }

        private static char ReadChar(string prompt)
        {
            char choice;
            Console.Write(prompt);
            string s = Console.ReadLine();
            choice = s[0];
            return choice;
        }
    }
}
