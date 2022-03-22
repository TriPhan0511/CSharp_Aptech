using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            int[] numbers = ReadIntArray();
            DisplayIntArray(numbers);

            // Sum of all values of elements in the array
            Console.WriteLine($"Sum of all values of elements in the array: {CalculateSum(numbers)}");

            // Calculate the average of the values of elements in an integer array
            Console.WriteLine($"Average: {CalculateAverage(numbers)}");

            // Find the maximum value and the position of that value
            int maxValue;
            int positionOfMaxValue;
            (maxValue, positionOfMaxValue) = FindMaxValueAndItsPosition(numbers);
            Console.WriteLine($"Maximum value in the array: {maxValue}");
            Console.WriteLine($"And it's postion in the array: {positionOfMaxValue}");

            // Get an integer from the user input
            // and search that number in the array.
            // If found, print the position of that number
            // Otherwise, print a message "Not found".
            int searchedValue;
            int lastOccurenceOfSearchedValue;
            Console.Write("Enter an integer which you want to search: ");
            searchedValue = int.Parse(Console.ReadLine());
            lastOccurenceOfSearchedValue = SearchAValue(numbers, searchedValue);
            if (lastOccurenceOfSearchedValue == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"The value {searchedValue} has found at the position {lastOccurenceOfSearchedValue}");
            }


            //// Display how many duplicates in the array
            //// and display the times each array's element occured
            //Dictionary<int, int> counts = CountOccurences(numbers);
            //Console.WriteLine($"There are {CountDuplicates(numbers)} duplicates.");
            //foreach (var pair in counts)
            //{
            //    Console.WriteLine($"Value {pair.Key} occured {pair.Value} time(s).");
            //}

            //// Sort an integer array in ascending order
            //Array.Sort(numbers);
            //Console.WriteLine("After sorting the array in ascending order:");
            //DisplayIntArray(numbers);
            //Console.WriteLine("numbers2:");

            //// Sort an integer array in descending order
            //Array.Sort(numbers);
            //Console.WriteLine("After sorting the array in descending order:");
            //Array.Reverse(numbers);
            //DisplayIntArray(numbers);
        }

        private int SearchAValue(int[] numbers, int searchedValue)
        {
            int pos = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchedValue)
                {
                    pos = i;
                }
            }
            return pos;
        }

        // Find the maximum value and the position of that value
        private (int,int) FindMaxValueAndItsPosition(int[] numbers)
        {
            int maxValue = numbers[0];
            int positionOfMaxValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                    positionOfMaxValue = i;
                }
            }
            return (maxValue, positionOfMaxValue);
        }

        private double CalculateAverage(int[] numbers)
        {
            double sum = 0.0;
            int count = 0;
            foreach (var item in numbers)
            {
                sum += item;
                count++;
            }
            if (count == 0)
            {
                return 0;
            }
            return sum / count;
        }

        // Count how many duplicates in an integer array
        private int CountDuplicates(int[] numbers)
        {
            int count = 0;
            var dictionary = CountOccurences(numbers);
            foreach (var pair in dictionary)
            {
                if (pair.Value > 1)
                {
                    count++;
                }
            }
            return count;
        }


        // Count the times of each element in an integer array occurred
        private Dictionary<int, int> CountOccurences(int[] numbers)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                {
                    dictionary[number] = 1;
                }
            }
            return dictionary;
        }

        // Calculate the sum of values of the element in an integer array
        private int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        // Display the content of an integer array
        private void DisplayIntArray(int[] numbers)
        {
            
            Console.WriteLine("The content of the array:");
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        // Get the values of the elements in an integer array
        private int[] ReadIntArray()
        {
            // Get the size of an array from user's input
            int size;
            Console.Write("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());

            // Get values of the element of the array
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
    }
}
