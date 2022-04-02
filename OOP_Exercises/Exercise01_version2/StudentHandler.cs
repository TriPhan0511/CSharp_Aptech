using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_version2
{
    internal class StudentHandler
    {
        public static PrimarySchoolStudent ReadAPrimarySchoolStudent()
        {
            string id = ReadString("Enter an id: "); ;
            string name = ReadString("Enter a name: ");
            int age = ReadAgeForPrimarySchoolStudent("Enter an age: ");
            double mathMark = ReadMark("Enter mark of the Math subject: ");
            double literatureMark = ReadMark("Enter mark of the Literature subject: ");
            double enghlishMark = ReadMark("Enter mark of the English subject: ");
            return new PrimarySchoolStudent(id, name, age,
                mathMark, literatureMark, enghlishMark);
        }

        public static JuniorHighSchoolStudent ReadAJuniorHighSchoolStudent()
        {
            string id = ReadString("Enter an id: "); ;
            string name = ReadString("Enter a name: ");
            int age = ReadAgeForJuniorHighSchoolStudent("Enter an age: ");
            double mathMark = ReadMark("Enter mark of the Math subject: ");
            double literatureMark = ReadMark("Enter mark of the Literature subject: ");
            double enghlishMark = ReadMark("Enter mark of the English subject: ");
            double physicMark = ReadMark("Enter mark of the Physic subject: ");
            double chemistryMark = ReadMark("Enter mark of the Chemistry subject: ");
            return new JuniorHighSchoolStudent(id, name, age,
                mathMark, literatureMark, enghlishMark,
                physicMark, chemistryMark);
        }
        
        public static HighSchoolStudent ReadAHighSchoolStudent()
        {
            string id = ReadString("Enter an id: "); ;
            string name = ReadString("Enter a name: ");
            int age = ReadAgeForHighSchoolStudent("Enter an age: ");
            double mathMark = ReadMark("Enter mark of the Math subject: ");
            double literatureMark = ReadMark("Enter mark of the Literature subject: ");
            double enghlishMark = ReadMark("Enter mark of the English subject: ");
            double physicMark = ReadMark("Enter mark of the Physic subject: ");
            double chemistryMark = ReadMark("Enter mark of the Chemistry subject: ");
            double computerScienceMark = ReadMark("Enter mark of the Computer Science subject: ");
            double frenchMark = ReadMark("Enter mark of the French subject: ");
            return new HighSchoolStudent(id, name, age, mathMark,
                literatureMark, enghlishMark,
                physicMark, chemistryMark,
                computerScienceMark, frenchMark);
        }

        // Helper method
        // A high school student should have an age between 15 and 18.
        private static int ReadAgeForHighSchoolStudent(string prompt)
        {
            int age;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    age = int.Parse(Console.ReadLine());
                    if (age < 15 || age > 18)
                    {
                        Console.WriteLine("A high school student should have an age between 15 and 18.\n" +
                            "Please try again.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input. You should enter a whole number between 15 and 18.\n" +
                        "Please try again.");
                }
            }
            return age;
        }

        // Helper method
        // A junior high school student should have an age between 11 and 15.
        private static int ReadAgeForJuniorHighSchoolStudent(string prompt)
        {
            int age;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    age = int.Parse(Console.ReadLine());
                    if (age < 11 || age > 15)
                    {
                        Console.WriteLine("A junior high school student should have an age between 11 and 15.\n" +
                            "Please try again.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input. You should enter a whole number between 11 and 15.\n" +
                        "Please try again.");
                }
            }
            return age;
        }

        // Helper method
        // A primary school student should have an age between 6 and 10.
        private static int ReadAgeForPrimarySchoolStudent(string prompt)
        {
            int age;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    age = int.Parse(Console.ReadLine());
                    if (age < 6 || age > 10)
                    {
                        Console.WriteLine("A primary school student should have an age between 6 and 10.\n" +
                            "Please try again.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input. You should enter a whole number between 6 and 10.\n" +
                        "Please try again.");
                }
            }
            return age;
        }

        // Helper method
        // A mark should be between 0 and 10
        private static double ReadMark(string prompt)
        {
            double mark;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    mark = double.Parse(Console.ReadLine());
                    if (mark < 0.0 || mark > 10.0)
                    {
                        Console.WriteLine("A mark should be between 0 and 10.\n" +
                            "Please try again.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input. You should enter a number between 0 and 10.\n" +
                        "Please try again.");
                }
            }
            return mark;
        }

        // Helper method
        private static string ReadString(string prompt)
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
    }
}
