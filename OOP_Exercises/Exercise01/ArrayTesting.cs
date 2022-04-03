using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class ArrayTesting
    {
        private PrimarySchoolStudent[] primarySchoolStudents;
        private JuniorHighSchoolStudent[] juniorHighSchoolStudents;
        private HighSchoolStudent[] highSchoolStudents;

        public void DisplayOptions()
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
                choice = Utils.ReadChar("Enter your choice: ");
                switch (choice)
                {
                    case '1':
                        primarySchoolStudents = StudentsManagement.CreateAnArrayOfPrimarySchoolStudent();
                        break;
                    case '2':
                        juniorHighSchoolStudents = StudentsManagement.CreateAnArrayOfJuniorHighSchoolStudent();
                        break;
                    case '3':
                        highSchoolStudents = StudentsManagement.CreateAnArrayOfHighSchoolStudent();
                        break;
                    case '4':
                        StudentsManagement.DisplayAnArrayOfStudents(primarySchoolStudents);
                        break;
                    case '5':
                        StudentsManagement.DisplayAnArrayOfStudents(juniorHighSchoolStudents);
                        break;
                    case '6':
                        StudentsManagement.DisplayAnArrayOfStudents(highSchoolStudents);
                        break;
                    case '7':
                        Console.Write("Goodbye");
                        break;
                    default:
                        Console.Write("Wrong choice.");
                        break;
                }
            } while (choice != '7');
        }
    }
}
