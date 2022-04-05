using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class StudentsManagement
    {
        // Create an array of PrimarySchoolStudent objects
        public static PrimarySchoolStudent[] CreateAnArrayOfPrimarySchoolStudent()
        {
            int size = ReadASizeOfAnArray("Enter a size of array: ");
            var students = new PrimarySchoolStudent[size];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = StudentHandler.ReadAPrimarySchoolStudent();
            }
            return students;
        }

        // Create an array of JuniorHighSchoolStudent objects
        public static JuniorHighSchoolStudent[] CreateAnArrayOfJuniorHighSchoolStudent()
        {
            int size = ReadASizeOfAnArray("Enter a size of array: ");
            var students = new JuniorHighSchoolStudent[size];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = StudentHandler.ReadAJuniorHighSchoolStudent();
            }
            return students;
        }

        // Create an array of HighSchoolStudent objects
        public static HighSchoolStudent[] CreateAnArrayOfHighSchoolStudent()
        {
            int size = ReadASizeOfAnArray("Enter a size of array: ");
            var students = new HighSchoolStudent[size];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = StudentHandler.ReadAHighSchoolStudent();
            }
            return students;
        }

        // Helper method
        // Set size for an array
        private static int ReadASizeOfAnArray(string prompt)
        {
            int size;
            while (true)
            {
                size = Utils.ReadInt(prompt);
                if (size < 1)
                {
                    Console.WriteLine("You should enter a whole number which is equal to or greater than 1.\n" +
                        "Please try again.");
                }
                else
                {
                    break;
                }
            }
            return size;
        }

        // Display content of an array containing Student type objects
        public static void DisplayAnArrayOfStudents(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("An empty array. Nothing to display.");
            }
            else
            {
                foreach (var item in students)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

