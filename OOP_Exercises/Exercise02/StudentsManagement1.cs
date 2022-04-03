using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise02
{
    // Use an array to contain Student objects
    internal class StudentsManagement1
    {
        private Student[] students;

        public void DisplayOptions()
        {
            char choice;
            do
            {
                // Menu options
                Console.WriteLine("\n-----Welcome to Student Management Application!-----\n");
                Console.WriteLine("1. Create an array of students.");
                Console.WriteLine("2. Search for a specific student and display his/her information.");
                Console.WriteLine("3. Display how many students in the array.");
                Console.WriteLine("4. Update the information of a specific student.");
                Console.WriteLine("5. Delete a specific student.");
                Console.WriteLine("6. Exit");
                choice = Utils.ReadChar("Enter your choice: ");
                switch (choice)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    default:
                        Console.Write("Wrong choice.");
                        break;
                }
            } while (choice != '6');
        }
    }
}
