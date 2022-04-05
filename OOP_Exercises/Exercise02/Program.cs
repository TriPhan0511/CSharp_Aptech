using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StudentsManagementUsingAnArray management = new StudentsManagementUsingAnArray();
    //        management.DisplayOptions();
    //    }
    //}


    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            DisplayNumbers(numbers);

            ResizeNumbers(numbers);
            Console.WriteLine($"Testing2 : {numbers.Length}");
            DisplayNumbers(numbers);

            //int deletedItem = 4;
            //if (DeleteItem(numbers, deletedItem))
            //{
            //    Console.WriteLine($"{deletedItem} was deleted.");
            //    Console.WriteLine("The content of the array now:");
            //    DisplayNumbers(numbers);
            //}
            //else
            //{
            //    Console.WriteLine($"The array is empty or the item {deletedItem} was not found.");
            //}


            ////int searchedItem = 1;
            ////int searchedItem = 4;
            ////int searchedItem = 5;
            //int searchedItem = 6;
            //int foundItem;
            //int index;
            //(foundItem, index) = SearchForItem(numbers, searchedItem);
            //if (index != -1)
            //{
            //    Console.WriteLine($"{foundItem} was found at the postion {index}.");
            //}
            //else
            //{
            //    Console.WriteLine($"{searchedItem} was NOT found.");
            //}

        }

        private static void ResizeNumbers(int[] numbers)
        {
            Array.Resize<int>(ref numbers, numbers.Length + 1);  
            Console.WriteLine($"Testing: {numbers.Length}");
        }

        private static bool DeleteItem(int[] numbers, int item)
        {
            int index;
            (_, index) = SearchForItem(numbers, item);
            if (index == -1)
            {
                return false;
            }

            // Initialize two arrays
            var arr1 = new int[numbers.Length - 2];
            var arr2 = new int[numbers.Length - arr1.Length - 1];

            // Fill the arr1 array
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = numbers[i];
            }

            // Fill the arr2 array
            int k = arr1.Length + 1;
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = numbers[k];
                k++;
            }

            // Resize the numbers array
            Array.Resize<int>(ref numbers, numbers.Length - 1);

            // Re fill the numbers array
            for (int i = 0; i < arr1.Length; i++)
            {
                numbers[i] = arr1[i];
            }
            int j = arr1.Length;
            for (int i = 0; i < arr2.Length; i++)
            {
                numbers[j] = arr2[i];
                j++;
            }

            // Testing
            Console.WriteLine("Testing:");
            Console.WriteLine("Arr1");
            DisplayNumbers(arr1);
            Console.WriteLine("Arr2");
            DisplayNumbers(arr2);
            Console.WriteLine("Numbers");
            DisplayNumbers(numbers);
            Console.WriteLine("--------------------------");

            return true;
        }

        // Search for a specific item in an array
        private static (int, int) SearchForItem(int[] numbers, int item)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == item)
                {
                    return (item, i);
                }
            }
            return (-1, -1);
        }

        // Display an array
        private static void DisplayNumbers(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
