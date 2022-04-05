using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise02
{
    // Use an array to contain Student objects
    internal class StudentsManagementUsingAnArray
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
                Console.WriteLine("2. Search for a specific student and display his/her information if found.");
                Console.WriteLine("3. Display how many students in the array.");
                Console.WriteLine("4. Update the information of a specific student.");
                Console.WriteLine("5. Delete a specific student.");
                Console.WriteLine("6. Display all students in the array.");
                Console.WriteLine("7. Exit");
                choice = Utils.ReadChar("Enter your choice: ");
                switch (choice)
                {
                    case '1':
                        //students = CreateAnArrayOfStudents();
                        students = FillDummyData();
                        break;
                    case '2':
                        FindAStudent(students);
                        break;
                    case '3':
                        CountStudents(students);
                        break;
                    case '4':
                        UpdateAStudent(students);
                        break;
                    case '5':
                        Console.WriteLine("Five");
                        break;
                    case '6':
                        DisplayAnArrayOfStudents(students);
                        break;
                    case '7':
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.Write("Wrong choice.");
                        break;
                }
            } while (choice != '7');
        }

        // Read an id from the user input
        // Then update the information of the student who has that id
        private void UpdateAStudent(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("The array is empty.");
            }
            else
            {
                string id = Utils.ReadString("Enter the student's id you want to update his/her information: ");
                if (UpdateAStudent(students, id))
                {
                    Console.WriteLine($"The information of the student whose id is {id} was updated.");
                }
                else
                {
                    Console.WriteLine($"The array is empty or could not find the student whose id is {id} in the array.");
                }
            }
        }

        // Helper method
        // Update the information of a student based on an id.
        private bool UpdateAStudent(Student[] students, string id)
        {
            Student found;
            int index;
            (found, index) = SearchForAStudent(students, id);
            if (found == null)
            {
                return false;
            }
            Console.WriteLine("----Enter the new information-----");
            Student tempStudent = ReadAStudent(id);
            students[index] = tempStudent;
            return true;
        }

        // Helper method
        // Create a Student object from entered information.
        private Student ReadAStudent(string id)
        {
            string name = Utils.ReadString("Enter a name: ");
            string phoneNumber = Utils.ReadString("Enter a phone number: ");
            string address = Utils.ReadString("Enter an address: ");
            return new Student(id, name, phoneNumber, address);
        }

        // Count how many students in an array
        private void CountStudents(Student[] students)
        {
            string s = students == null || students.Length == 0 ?
                "There is not any student in the array." :
                students.Length == 1 ?
                "There is only one student in the array." :
                $"There are {students.Length} students in the array.";
            Console.WriteLine(s);
        }

        // Read an id entered by the user
        // Then search for a student whose entered id.
        private void FindAStudent(Student[] students)
        {
            string id = Utils.ReadString("Enter the id of the student you want to search for: ");
            Student found;
            (found, _) = SearchForAStudent(students, id);
            if (found == null)
            {
                Console.WriteLine($"The array is empty or the student whose id is {id} does not exists in the array.");
            }
            else
            {
                Console.WriteLine(found);
            }
        }

        // Search for a specific student in an array based on a student's id.
        // If found, return a Student object whose that id and the index of object in the array.
        // Otherwise, return null and -1.
        private (Student, int) SearchForAStudent(Student[] students, string id)
        {
            if (students == null || students.Length == 0)
            {
                return (null, -1);
            }
            else
            {
                for (int i = 0; i < students.Length; i++)
                {
                    string tempID = students[i].Id;
                    if (tempID.Equals(id, StringComparison.CurrentCultureIgnoreCase))
                    {
                        return (students[i], i);
                    }
                }
            }
            return (null, -1);
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

        // Helper method
        // Display content of an array containing Student type objects
        private static void DisplayAnArrayOfStudents(Student[] students)
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

        // Helper method
        private Student[] CreateAnArrayOfStudents()
        {
            int size = ReadASizeOfAnArray("Enter a size of array: ");
            var students = new Student[size];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = StudentHandler.ReadAStudent();
            }
            return students;
        }

        // Dummy data : Should be deleted in the end
        private Student[] FillDummyData()
        {
            Student s1 = new Student("s1", "Alex", "0905123456", "123nct");
            Student s2 = new Student("s2", "Brad", "0905123456", "123nct");
            Student s3 = new Student("s3", "Chris", "0905123456", "123nct");
            Student s4 = new Student("s4", "Celline", "0905123456", "123nct");
            Student s5 = new Student("s5", "Duff", "0905123456", "123nct");
            return new Student[] { s1, s2, s3, s4, s5 };
            //return new Student[] { s1 };
        }
    }
}
