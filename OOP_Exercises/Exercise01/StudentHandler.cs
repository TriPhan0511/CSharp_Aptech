using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class StudentHandler
    {
        public static PrimarySchoolStudent ReadAPrimarySchoolStudent()
        {
            string id = Utils.ReadString("Enter an id: "); ;
            string name = Utils.ReadString("Enter a name: ");
            int age = ReadAgeForPrimarySchoolStudent("Enter an age (an age for a primary school student should be between 6 and 10): ");
            double mathMark = ReadMark("Enter mark of the Math subject: ");
            double literatureMark = ReadMark("Enter mark of the Literature subject: ");
            double enghlishMark = ReadMark("Enter mark of the English subject: ");
            return new PrimarySchoolStudent(id, name, age,
                mathMark, literatureMark, enghlishMark);
        }

        public static JuniorHighSchoolStudent ReadAJuniorHighSchoolStudent()
        {
            string id = Utils.ReadString("Enter an id: "); ;
            string name = Utils.ReadString("Enter a name: ");
            int age = ReadAgeForJuniorHighSchoolStudent("Enter an age (an age for a junior high school student should be between 11 and 15): ");
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
            string id = Utils.ReadString("Enter an id: "); ;
            string name = Utils.ReadString("Enter a name: ");
            int age = ReadAgeForHighSchoolStudent("Enter an age (an age for a high school student should be between 15 and 18): ");
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
                age = Utils.ReadInt(prompt);
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
            return age;
        }

        // Helper method
        // A junior high school student should have an age between 11 and 15.
        private static int ReadAgeForJuniorHighSchoolStudent(string prompt)
        {
            int age;
            while (true)
            {
                age = Utils.ReadInt(prompt);
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
            return age;
        }

        // Helper method
        // A primary school student should have an age between 6 and 10.
        private static int ReadAgeForPrimarySchoolStudent(string prompt)
        {
            int age;
            while (true)
            {
                age = Utils.ReadInt(prompt);
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
            return age;
        }

        // Helper method
        // A mark should be between 0 and 10
        private static double ReadMark(string prompt)
        {
            double mark;
            while (true)
            {
                mark = Utils.ReadDouble(prompt);
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
            return mark;
        }
    }
}
