using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercise 7
namespace Array_Students
{
    internal class Program
    {
        private string[,] students;

        static void Main(string[] args)
        {
            (new Program()).DisplayOptions();
        }

        // Remove a student from the two-dimensional array based on his/her id.
        private static void RemoveAStudentBasedOnID(string[,] source, int index)
        {
            int rows = source.GetLength(0);
            int cols = source.GetLength(1); 
            string[,] des1 = new string[index, cols];
            string[,] des2 = new string[rows - index - 1, cols];

            // Phase 1: Coppy from the source array to two destination arrays
            Array.Copy(source, des1, des1.Length);
            Array.Copy(source, des1.Length + cols, des2, 0, des2.Length);

            // Phase 2: Copy from the two destination arrays to the sorce array
            Array.Copy(des1, source, des1.Length);
            Array.Copy(des2, 0, source, des1.Length, source.Length - (des1.Length + 4));
            for (int i = 0; i < source.GetLength(1); i++)
            {
                source[source.GetLength(0) - 1, i] = null;
            }
        }

        private void DisplayOptions()
        {
            int choice;
            do
            {
                // Menu options
                Console.WriteLine("\n-----Welcome to student manager app (using an array)!-----\n");
                Console.WriteLine("1. Enter a two-dimensional array.");
                Console.WriteLine("2. Display the two-dimensional array.");
                Console.WriteLine("3. Update a student based on his/her id.");
                Console.WriteLine("4. Remove a student from the array based on his/her id.");
                Console.WriteLine("5. Exit the program.");
                choice = Utils.ReadInt("\nYour choice: ");
                switch (choice)
                {
                    case 1:
                        students = CreateATwoDimensionalArray();
                        break;
                    case 2:
                        Display(students);
                        break;
                    case 3:
                        UpdateAStudent(students);
                        break;
                    case 4:
                        RemoveAStudent(students);
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        break;
                }
            } while (choice != 5);
        }

        private void RemoveAStudent(string[,] students)
        {
            string id = Utils.ReadString("Enter an ID: ");
            int index = SearchAStudent(students, id);
            if (index == -1)
            {
                Console.WriteLine($"Cannot find any student whose ID is {id}.");
            }
            else
            {
                RemoveAStudentBasedOnID(students, index);
                Console.WriteLine("Removed.");
            }
        }

        private void UpdateAStudent(string[,] students)
        {
            string id = Utils.ReadString("Enter an ID: ");
            int index= SearchAStudent(students, id);
            if (index == -1)
            {
                Console.WriteLine($"Cannot find any student whose ID is {id}.");
            }
            else
            {
                students[index, 1] = Utils.ReadString("Name: ");
                students[index, 2] = Utils.ReadString("Phone number: ");
                students[index, 3] = Utils.ReadString("Address: ");
                Console.WriteLine("Updated.");
            }
        }

        private static string[,] CreateATwoDimensionalArray()
        {
            int size = Utils.ReadInt("How many students do you want to add to the array? ");
            string[,] students = AddStudents(size);
            return students;
        }

        int SearchAStudent(string[,] students, string id)
        {
            if (students == null || students.Length == 0)
            {
                return -1;
            }
            for (int i = 0; i < students.GetLength(0); i++)
            {
                if (String.Equals(students[i, 0], id, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }


        // Display content of a two-dimensional array
        private static void Display(string[,] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Nothing to show.");
            }
            else
            {
                for (int i = 0; i < students.GetLength(0); i++)
                {
                    for (int j = 0; j < students.GetLength(1); j++)
                    {
                        Console.Write($"{students[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        // Get data for an array
        private static string[,] AddStudents(int size)
        {

            string[,] students = new string[size, 4];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter information of the student {i + 1}: ");
                students[i, 0] = Utils.ReadString("ID: ");
                students[i, 1] = Utils.ReadString("Name: ");
                students[i, 2] = Utils.ReadString("Phone number: ");
                students[i, 3] = Utils.ReadString("Address: ");
            }
            return students;
        }

        //// Dummy data
        //private string[,] InitializeStudents()
        //{
        //    string[,] students =
        //    {
        //        { "s1", "Alex", "0905", "302nct" },
        //        { "s2", "Peter", "0511", "456ld" },
        //        { "s3", "Rose", "0987", "987nct" }
        //    };

        //    //string[,] students =
        //    //{
        //    //    { "s1", "Alex", "0905", "302nct" },
        //    //    { "s2", "Peter", "0511", "456ld" },
        //    //    { "s3", "Rose", "0987", "987nct" },
        //    //    { "s4", "Mary", "0987", "987nct" },
        //    //    { "s5", "David", "0987", "987nct" },
        //    //    { "s6", "Hillary", "0987", "987nct" },
        //    //    { "s7", "Henry", "0987", "987nct" },
        //    //};

        //    return students;
        //}
    }
}
