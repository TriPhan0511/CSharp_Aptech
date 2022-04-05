using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_A_List_Sample
{
    // The following example demonstrates the Sort(Comparison<T>) method overload.

    // The example defines an alternative comparison method for strings, named CompareDinosByLength.
    // This method works as follow: First, the comparands are tested for null, and a null reference is
    // treated as less than a non-null. Second, the string lenghts are compared, and the longer string
    // is deemed to be greater. Third, if the lengths are equal, ordinary string comparison is used.

    // A List<T> of strings is created and populated with four strings, in no particular order.
    // The list also includes an empty string and a null reference.
    // The list is displayed, sorted using a Comparison<T> generic delegate representing the
    // CompareDinosByLength method, and displayed again.
    //internal class Example2
    //{
    //    private static int CompareDinosByLength(string x, string y)
    //    {
    //        if (x == null && y == null)
    //        {
    //            return 0;
    //        }
    //        else if (x == null)
    //        {
    //            return -1;
    //        }
    //        else if (y == null)
    //        {
    //            return 1;
    //        }
    //        else
    //        {
    //            int retval = x.Length.CompareTo(y.Length);
    //            if (retval != 0)
    //            {
    //                return retval;
    //            }
    //            else
    //            {
    //                return x.CompareTo(y);
    //            }
    //        }
    //    }

    //    private static int CompareDinosByLength_0(string x, string y)
    //    {
    //        if (x == null)
    //        {
    //            if (y == null)
    //            {
    //                // If x is null and y is null, they're equal.
    //                return 0;
    //            }
    //            else
    //            {
    //                // If x is null and y is not null, y is greater.
    //                return -1;
    //            }
    //        }
    //        else
    //        {
    //            // If x is not null...
    //            if (y == null)
    //                // ... and y is null, x is greater
    //            {
    //                return 1;
    //            }
    //            else
    //            {
    //                // ... and y is not null, compare the lengths of the two strings.
    //                int retval = x.Length.CompareTo(y.Length);
    //                if (retval != 0)
    //                {
    //                    // If the strings are not equal of length,
    //                    // the longer string is greater.
    //                    return retval;
    //                }
    //                else
    //                {
    //                    // If the strings are of equal length,
    //                    // sort them with ordinary string comparison
    //                    return x.CompareTo(y);
    //                }
    //            }
    //        }
    //    }

    //    public static void Main(string[] args)
    //    {
    //        List<string> dinosaurs = new List<string>();
    //        dinosaurs.Add("Pachycephalosaurus");
    //        dinosaurs.Add("Bmargasaurus");
    //        dinosaurs.Add("Amargasaurus");
    //        dinosaurs.Add("");
    //        dinosaurs.Add(null);
    //        dinosaurs.Add("Mamenchisaurus");
    //        dinosaurs.Add("Deinonychus");
    //        Display(dinosaurs);

    //        Console.WriteLine("\nSort with generic Comparison<string> delegate:");
    //        dinosaurs.Sort(CompareDinosByLength);
    //        Display(dinosaurs);

    //        /*
             
    //        "Pachycephalosaurus"
    //        "Bmargasaurus"
    //        "Amargasaurus"
    //        ""
    //        (null)
    //        "Mamenchisaurus"
    //        "Deinonychus"

    //        Sort with generic Comparison<string> delegate:

    //        (null)
    //        ""
    //        "Deinonychus"
    //        "Amargasaurus"
    //        "Bmargasaurus"
    //        "Mamenchisaurus"
    //        "Pachycephalosaurus"
             
    //         */
    //    }

    //    // Helper method
    //    private static void Display(List<string> list)
    //    {
    //        Console.WriteLine();
    //        foreach (string item in list)
    //        {
    //            if (item == null)
    //            {
    //                Console.WriteLine("(null)");
    //            }
    //            else
    //            {
    //                Console.WriteLine($"\"{item}\"");
    //            }
    //        }
    //    }
    //}
}
