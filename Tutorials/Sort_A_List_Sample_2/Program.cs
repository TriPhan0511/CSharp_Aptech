using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_A_List_Sample_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Student objects
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 5, Name = "Blex Zozo" });
            students.Add(new Student() { Id = 4, Name = "Alex Zozo Wowow" });
            students.Add(new Student() { Id = 7, Name = "Brad Yoyo" });
            students.Add(new Student() { Id = 6 });
            students.Add(new Student() { Id = 1, Name = "Zed Bobby" });
            students.Add(new Student() { Id = 3, Name = "Yvoan Anchor" });
            students.Add(new Student() { Id = 2, Name = "Chris Labor" });

            // Display the list
            DisplayStudents(students);

            // Call Sort method on the list.
            // This will use the default comparer, which is the CompareTo method
            // implemented on Student.
            students.Sort();

            Console.WriteLine("\nAfter sort by Id (default):");
            DisplayStudents(students);

            // Call the Sort(Comparison(T)) overload using
            // an anonymous method for the Comparison delegate.
            // This method treats null as the lesser of two values.
            students.Sort(delegate (Student student1, Student student2)
            {
                if (student1.Name == null && student2.Name == null)
                {
                    return 0;
                }
                else if (student1.Name == null)
                {
                    return -1;
                }
                else if (student2.Name == null)
                {
                    return 1;
                }
                else
                {
                    return student1.Name.CompareTo(student2.Name);
                }
            });

            Console.WriteLine("\nAfter sort by Name:");
            DisplayStudents(students);

            // Sort with generic Comparison(Student) delegate
            students.Sort(CompareStudentByLengthOfName);

            Console.WriteLine("\nSort with generic Comparison(Student) delegate:");
            DisplayStudents(students);
        }

        private static int CompareStudentByLengthOfName(Student s1, Student s2)
        {
            if (s1.Name == null && s2.Name == null)
            {
                return 0;
            }
            else if (s1.Name == null)
            {
                return -1;
            }
            else if (s2.Name == null)
            {
                return 1;
            }
            else
            {
                int retval = s1.Name.Length.CompareTo(s2.Name.Length);
                if (retval != 0)
                {
                    return retval;
                }
                else
                {
                    return s1.Name.CompareTo(s2.Name);
                }
            }
        }

        private static void DisplayStudents(List<Student> students)
        {
            Console.WriteLine();
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
