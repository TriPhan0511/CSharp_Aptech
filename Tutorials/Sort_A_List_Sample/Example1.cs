using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_A_List_Sample
{
    // The following code demonstrates the Sort and Sort method overloads on a simple business object.
    // Calling the Sort method results in the use of the default comparer for the Part type,
    // and the Sort method is implemented using an anonymous method.

    // This sample illustrates how to sort the elements in the entire List<T> using the specified Comparison<T>:
    // Sort(Comparison<T>)

    // Simple business object. 
    // A PartId is used to identify the type of part
    // but the part name can change.
    public class Part : IEquatable<Part>, IComparable<Part>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }

        // Override the ToString() method
        public override string ToString()
        {
            return $"ID: {PartId} Name: {PartName}";
        }

        // Override the base class implementation of Equals(Object)
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Part objAsPart = obj as Part;
            if (objAsPart == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsPart);
            }
        }

        // Implement interface member IComparable.CompareTo(Part)
        // Default comparer for Part type
        public int CompareTo(Part comparePart)
        {
            // A null value means that this object is greater
            if (comparePart == null)
            {
                return 1;
            }
            else
            {
                return this.PartId.CompareTo(comparePart.PartId);
            }
        }

        // Override the base class implementation of GetHashCode() 
        public override int GetHashCode()
        {
            return PartId;
        }

        // Implement interface member IEquatable.Equals(Part)
        public bool Equals(Part other)
        {
            if (other == null)
            {
                return false;
            }
            return (this.PartId.Equals(other.PartId));
        }
    }
    internal class Example1
    {
        public static void Main(string[] args)
        {
            // Create a list of parts
            List<Part> parts = new List<Part>();

            // Add parts to the list
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });
            // Name intentionally left null
            parts.Add(new Part() { PartId = 1334 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });

            // Write out the parts in the list. This will call the overridden
            // ToString method in the Part class.
            Console.WriteLine("\nBefore sort:");
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            // Call Sort on the list. This will use the
            // default comparer, which is the CompareTo method
            // implemented on Part.
            parts.Sort();

            Console.WriteLine("\nAfter sort by part number:");
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            // This shows calling the Sort(Comparison(T) overload using
            // an anonymous method for the Comparison delegate.
            // This method treats null as the lesser of two values.
            parts.Sort(delegate (Part x, Part y)
            {
                if (x.PartName == null && y.PartName == null)
                {
                    return 0;
                }
                else if (x.PartName == null)
                {
                    return -1;
                }
                else if (y.PartName == null)
                {
                    return 1;
                }
                else
                {
                    return x.PartName.CompareTo(y.PartName);
                }
            });

            Console.WriteLine("\nAfter sort by name:");
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            /*
             
            Before sort:
            ID: 1434 Name: regular seat
            ID: 1234 Name: crank arm
            ID: 1634 Name: shift lever
            ID: 1334 Name:
            ID: 1444 Name: banana seat
            ID: 1534 Name: cassette

            After sort by part number:
            ID: 1234 Name: crank arm
            ID: 1334 Name:
            ID: 1434 Name: regular seat
            ID: 1444 Name: banana seat
            ID: 1534 Name: cassette
            ID: 1634 Name: shift lever

            After sort by name:
            ID: 1334 Name:
            ID: 1444 Name: banana seat
            ID: 1534 Name: cassette
            ID: 1234 Name: crank arm
            ID: 1434 Name: regular seat
            ID: 1634 Name: shift lever

             */
        }
    }
}
