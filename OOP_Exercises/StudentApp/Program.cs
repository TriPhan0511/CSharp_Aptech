using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
            Console.ReadLine(); // use this to pause the program
        }

        private void run()
        {
            // primary : primary school (age is between 6 and 14).
            // elementary : elementary school (age is between 11 and 15).
            // high : high school (age is between 15 and 18).

            //Student student = InitializeAStudent("PRIMARY");
            //Student student = InitializeAStudent("elementary");
            Student student = InitializeAStudent("high");
            Console.WriteLine(student);
        }

        // Helper method
        private Student InitializeAStudent(string level)
        {
            
            string tempID = GetID("Enter an id: ");
            string tempName = GetName("Enter a name: ");
            int tempAge = GetAge(level);
            if (level.Equals("primary", StringComparison.CurrentCultureIgnoreCase))
            {
                return new PrimarySchoolStudent(tempID, tempName, tempAge);
            }
            else if (level.Equals("elementary", StringComparison.CurrentCultureIgnoreCase))
            {
                return new ElementarySchoolStudent(tempID, tempName, tempAge);
            }
            return new HighSchoolStudent(tempID, tempName, tempAge);
                
        }

        // Get an age from user input
        private static int GetAge(string level)
        {
            int tempAge;
            while (true)
            {
                try
                {
                    if (level.Equals("primary", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.Write("Enter an age (an age for a primary school student should be between 6 and 14): ");
                        tempAge = int.Parse(Console.ReadLine());
                        if (tempAge < 6 || tempAge > 14)
                        {
                            Console.WriteLine("Invalid age for a primary student.\n" +
                                "You should enter a number between 6 and 14.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (level.Equals("elementary", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.Write("Enter an age (an age for a elementary school student should be between 11 and 15): ");
                        tempAge = int.Parse(Console.ReadLine());
                        if (tempAge < 11 || tempAge > 15)
                        {
                            Console.WriteLine("Invalid age for a elementary school student.\n" +
                                "You should enter a number between 11 and 15.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("Enter an age (an age for a high school student should be between 15 and 18): ");
                        tempAge = int.Parse(Console.ReadLine());
                        if (tempAge < 15 || tempAge > 18)
                        {
                            Console.WriteLine("Invalid age for a high school student.\n" +
                                "You should enter a number between 15 and 18.");
                        }
                        else
                        {
                            Console.WriteLine(tempAge);
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid age. You should enter a number.");
                }
            }

            return tempAge;
        }
        
        // Get a name from user input
        private static string GetName(string prompt)
        {
            string tempName;
            while (true)
            {
                Console.Write(prompt);
                tempName = Console.ReadLine();
                if (tempName.Trim().Length == 0)
                {
                    Console.WriteLine("You should not enter an empty string.");
                }
                else
                {
                    break;
                }
            }

            return tempName;
        }

        // Get an id from user input
        private static string GetID(string prompt)
        {
            string tempID;
            while (true)
            {
                Console.Write(prompt);
                tempID = Console.ReadLine();
                if (tempID.Trim().Length == 0)
                {
                    Console.WriteLine("You should not enter an empty string.");
                }
                else
                {
                    break;
                }
            }

            return tempID;
        }
    }
}
