using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> authors = new List<string>();
            //authors.Add("Mahes Chand");
            //authors.Add("Chris Love");
            //authors.Add("Allen O'neil");
            //authors.Add("Ernest Hemingway");
            //authors.Add("J.K. Rowling");
            //authors.Add("David love");
            //DisplayAuthors(authors);
            //Console.WriteLine("-----------------------------------");
            //Mahes Chand
            //Chris Love
            //Allen O'neil
            //Ernest Hemingway
            //J.K.Rowling

            //// Insert an element at a postion
            //authors.Insert(0, "Stephen King");
            //authors.Insert(2, "Mark Twain");
            //DisplayAuthors(authors);
            ////Stephen King
            ////Mahes Chand
            ////Mark Twain
            ////Chris Love
            ////Allen O'neil
            ////Ernest Hemingway
            ////J.K.Rowling
            /////-------------------------------------------------------------------------------

            // Remove items from a List
            //authors.Remove("Chris Love");
            //DisplayAuthors(authors);
            ////Mahes Chand
            ////Allen O'neil
            ////Ernest Hemingway
            ////J.K.Rowling

            //authors.RemoveRange(1, 2);
            //DisplayAuthors(authors);
            ////Mahes Chand
            ////Ernest Hemingway
            ////J.K.Rowling

            //authors.RemoveAt(3);
            //DisplayAuthors(authors);
            ////Mahes Chand
            ////Chris Love
            ////Allen O'neil
            ////J.K.Rowling

            //Console.WriteLine($"\nTrueForAll(EndsWithLove): {authors.TrueForAll(EndsWithLove)}");
            //Console.WriteLine($"\nFind(EndsWithLove): {authors.Find(EndsWithLove)}");
            //Console.WriteLine($"\nFindLast(EndsWithLove): {authors.FindLast(EndsWithLove)}");
            //Console.WriteLine($"\nFindAll(EndsWithLove):");
            //List<string> sublist = authors.FindAll(EndsWithLove);
            //DisplayAuthors(sublist);

            //// Remove elements based on a condition (predicate)
            //Console.WriteLine($"\n{authors.RemoveAll(EndsWithLove)} elements removed by RemoveAll(EndsWithLove)");
            //Console.WriteLine("\nList now contains:");
            //DisplayAuthors(authors);

            //// Remove all items from the List
            //authors.Clear();
            //Console.WriteLine($"Count(authors): {authors.Count}"); // 0
            /////-------------------------------------------------------------------------------

            //// Find an element in a List
            //// The IndexOf method finda an item in a List.
            //// The IndexOf method returns -1 if there are no items found in the List.
            //int index = authors.IndexOf("Ernest Hemingway");
            //if (index == -1)
            //{
            //    Console.WriteLine("Item not found.");
            //}
            //else
            //{
            //    Console.WriteLine($"Item's index in the list is: {index}"); // 3
            //}

            //// The LastIndexOf method finds an item from the end of List
            ////Console.WriteLine(authors.LastIndexOf("Chris Love"));
            //string s = authors.FindLast(EndsWithLove);
            //int index = authors.IndexOf(s);
            //Console.WriteLine(index); // 5
            /////-------------------------------------------------------------------------------

            // Sort a List
            // The Sort method of List<T> sorts all item of a List using the QuickSort algorithm
            List<string> authors = new List<string>();
            authors.Add("Mahes Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neil");
            authors.Add("Naveen Sharma");
            authors.Add("Mahesh Chand");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");
            Console.WriteLine("Original List:\n");
            DisplayAuthors(authors);
            Console.WriteLine("\n-----------------------------------");

            // Sort List's items
            authors.Sort();
            Console.WriteLine("\nAfter soring\n");
            DisplayAuthors(authors);
        }

        private static void ToLowerAList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].ToLower();
            }
        }

        // Display the content of a List containing string objects
        private static void DisplayAuthors(List<string> list)
        {
            list.ForEach(item => Console.WriteLine(item));
        }

        private static bool EndsWithLove(string s)
        {
            return s.ToLower().EndsWith("love");
        }
    }
}
