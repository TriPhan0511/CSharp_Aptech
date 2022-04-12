using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays_Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
        }

        private void Run()
        {
            // Get data for the array
            int size = Utils.ReadInt("How many students do you want to add to the array? ");
            string[,] students = AddStudents(size);
            // Display the array
            Display(students);
        }

        // Search a student based on his/her id
        int SearchAStudent(string[,] students, string id)
        {
            if (students == null || students.Length == 0)
            {
                return -1;
            }
            for (int i = 0; i < students.GetLength(0); i++)
            {
                if (String.Equals(students[i,0], id, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }


        // Display an array
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
                    for (int j = 0; j < students.Rank; j++)
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

        //private string[] AddStudent()
        //{
        //    string id = Utils.ReadString("ID: ");
        //    string name = Utils.ReadString("Name: ");
        //    string phoneNumber = Utils.ReadString("Phone number: ");
        //    string address = Utils.ReadString("Address: ");
        //    return new string[] { id, name, phoneNumber, address };
        //}

        //static void Main(string[] args)
        //{
        //    // Two-dimensional array of four rows and two columns
        //    //int[,] array2D = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        //    //string[,] array2D_string = { { "one", "two" }, { "three", "four" }, { "five", "six" }, { "seven", "eight" } };
        //    //int[,] array2D = new int[4,2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        //    string[,] array2D_string = new string[4, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" }, { "seven", "eight" } };
        //    //string[,] array2D_string = new string[5, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" }, { "seven", "eight" }, { "nine", "ten" } };

        //    //Console.WriteLine($"Length = {array2D_string.Length}"); // 8
        //    //Console.WriteLine($"Rank = {array2D_string.Rank}"); // 2
        //    //Console.WriteLine($"GetLength = {array2D_string.GetLength(0)}"); // 4 

        //    for (int i = 0; i < array2D_string.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array2D_string.Rank; j++)
        //        {
        //            Console.Write($"{array2D_string[i, j]} ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
