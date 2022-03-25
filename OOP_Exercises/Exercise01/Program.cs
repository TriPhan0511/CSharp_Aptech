using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
            Console.ReadLine(); // Use this to pause the program
        }

        private void Run()
        {
            //// Declare an array contaning PrimarySchoolStudent instances
            //PrimarySchoolStudent[] primarySchoolStudents = new PrimarySchoolStudent[2];
            //// Get data for the primarySchoolStudents
            //ReadAnArrayOfPrimarySchoolStudents(primarySchoolStudents);
            //// Display the content of an array containing PrimarySchoolStudent instances
            //displayStudents(primarySchoolStudents);

            //// Declare an array contaning JuniorHighSchoolStudent instances
            //JuniorHighSchoolStudent[] juniorHighSchoolStudents = new JuniorHighSchoolStudent[2];
            //// Get data for the primarySchoolStudents
            //ReadAnArrayOfJuniorHighSchoolStudents(juniorHighSchoolStudents);
            //// Display the content of an array containing JuniorHighSchoolStudent instances
            //displayStudents(juniorHighSchoolStudents);

            // Declare an array contaning JuniorHighSchoolStudent instances
            HighSchoolStudent[] highSchoolStudents = new HighSchoolStudent[2];
            // Get data for the primarySchoolStudents
            ReadAnArrayOfHighSchoolStudents(highSchoolStudents);
            // Display the content of an array containing JuniorHighSchoolStudent instances
            displayStudents(highSchoolStudents);
        }

        private void ReadAnArrayOfHighSchoolStudents(HighSchoolStudent[] highSchoolStudents)
        {
            // Enter data for the highSchoolStudents array
            for (int i = 0; i < highSchoolStudents.Length; i++)
            {
                string id = ReadID("Enter an id: ");
                string name = ReadName("Enter a name: ");
                int age = ReadAge("high");
                double mathMark = ReadMark("Enter the math's mark: ");
                double literatureMark = ReadMark("Enter the literature's mark: ");
                double englishMark = ReadMark("Enter the English's mark: ");
                double physicMark = ReadMark("Enter the physic's mark: ");
                double chemistryMark = ReadMark("Enter the chemistry's mark: ");
                double computerScienceMark = ReadMark("Enter the computer science's mark: ");
                double frenchMark = ReadMark("Enter the French's mark: ");
                highSchoolStudents[i] = new HighSchoolStudent(id, name, age, mathMark, 
                    literatureMark, englishMark, physicMark, chemistryMark, computerScienceMark, frenchMark);
            }
        }

        private void ReadAnArrayOfJuniorHighSchoolStudents(JuniorHighSchoolStudent[] juniorHighSchoolStudents)
        {
            // Enter data for the juniorHighSchoolStudents array
            for (int i = 0; i < juniorHighSchoolStudents.Length; i++)
            {
                string id = ReadID("Enter an id: ");
                string name = ReadName("Enter a name: ");
                int age = ReadAge("junior");
                double mathMark = ReadMark("Enter the math's mark: ");
                double literatureMark = ReadMark("Enter the literature's mark: ");
                double englishMark = ReadMark("Enter the english's mark: ");
                double physicMark = ReadMark("Enter the physic's mark: ");
                double chemistryMark = ReadMark("Enter the chemistry's mark: ");
                juniorHighSchoolStudents[i] = new JuniorHighSchoolStudent(id, name, age, mathMark, literatureMark, englishMark, physicMark, chemistryMark);
            }
        }

        private void ReadAnArrayOfPrimarySchoolStudents(PrimarySchoolStudent[] primarySchoolStudents)
        {
            // Enter data for the primarySchoolStudents array
            for (int i = 0; i < primarySchoolStudents.Length; i++)
            {
                string id = ReadID("Enter an id: ");
                string name = ReadName("Enter a name: ");
                int age = ReadAge("primary");
                double mathMark = ReadMark("Enter the math's mark: ");
                double literatureMark = ReadMark("Enter the literature's mark: ");
                double englishMark = ReadMark("Enter the english's mark: ");
                primarySchoolStudents[i] = new PrimarySchoolStudent(id, name, age, mathMark, literatureMark, englishMark);
            }
        }

        private void displayStudents(Student[] students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        private double ReadMark(string prompt)
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
                        Console.WriteLine("Invalid mark. A mark should be between 0 and 10.");
                    }
                    else
                    {
                        return mark;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid mark. Try again.");
                }
            }
        }

        private int ReadAge(string level)
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
                    else if (level.Equals("junior", StringComparison.CurrentCultureIgnoreCase))
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

        private string ReadName(string prompt)
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

        private string ReadID(string prompt)
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

        private void Run2()
        {
            //// Initialize a Student instance
            //string id = "stu001";
            //string name = "Alex";
            ////double mathMark = -1.0;
            ////double literatureMark = 11.0;
            //double mathMark = 0.0;
            //double literatureMark = 10.0;
            //double englishMark = 5.5;
            ////Student student = new Student(id, name, mathMark, literatureMark, englishMark);
            ////Console.WriteLine(student);

            //// Initialize a PrimarySchoolStudent instance
            //string id = "stu001";
            //string name = "Alex";
            ////double mathMark = -1.0;
            ////double literatureMark = 11.0;
            //double mathMark = 0.0;
            //double literatureMark = 10.0;
            //double englishMark = 5.5;

            ////int age = -1;
            ////int age = 0;
            ////int age = 11;
            //int age = 8;
            //Student student = new PrimarySchoolStudent(id, name, age, mathMark, literatureMark, englishMark);
            //Console.WriteLine(student);

            //// Initialize a Junior High School instance
            //string id = "stu001";
            //string name = "Alex";
            ////double mathMark = -1.0;
            ////double literatureMark = 11.0;
            //double mathMark = 0.0;
            //double literatureMark = 10.0;
            //double englishMark = 5.5;

            ////int age = -1;
            ////int age = 0;
            ////int age = 8;
            //int age = 14;

            //double physicMark = 5.0;
            //double chemistryMark = 9.0;
            //Student student = new JuniorHighSchoolStudent(id, name, age, mathMark, 
            //    literatureMark, englishMark, physicMark, chemistryMark);
            //Console.WriteLine(student);

            // Initialize a High School instance
            string id = "stu001";
            string name = "Alex";
            //double mathMark = -1.0;
            //double literatureMark = 11.0;
            double mathMark = 0.0;
            double literatureMark = 10.0;
            double englishMark = 5.5;

            //int age = -1;
            //int age = 0;
            //int age = 8;
            //int age = 14;
            int age = 17;

            double physicMark = 5.0;
            double chemistryMark = 9.0;

            double computerScienceMark = 7.5;
            double frenchMark = 5.5;

            Student student = new HighSchoolStudent(id, name, age, mathMark,
                literatureMark, englishMark, physicMark, chemistryMark, computerScienceMark, frenchMark);
            Console.WriteLine(student);
        }
    }
}
