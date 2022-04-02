using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This version uses properties
namespace Exercise01_version2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            ArrayTesting.DisplayOptions();
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        (new Program()).Run();
    //        //Console.ReadLine(); // Pause the program
    //    }

    //    //private void Run()
    //    //{
    //    //    //// Create an array of PrimarySchoolStudent objects and display the content of it
    //    //    //var students = StudentsManagement.CreateAnArrayOfPrimarySchoolStudent();
    //    //    //StudentsManagement.DisplayAnArrayOfStudents(students);
    //    //    ////---------------------------------------------------------------------
    //    //    ///

    //    //    //// Create an array of JuniorHighSchoolStudent objects and display the content of it
    //    //    //var students = StudentsManagement.CreateAnArrayOfJuniorHighSchoolStudent();
    //    //    //StudentsManagement.DisplayAnArrayOfStudents(students);

    //    //    // Create an array of HighSchoolStudent objects and display the content of it
    //    //    var students = StudentsManagement.CreateAnArrayOfHighSchoolStudent();
    //    //    StudentsManagement.DisplayAnArrayOfStudents(students);
    //    //}

    //    //private void Run()
    //    //{
    //    //    //// Create a PrimarySchoolStudent object
    //    //    //var student = StudentHandler.ReadAPrimarySchoolStudent();
    //    //    //Console.WriteLine(student);
    //    //    ////----------------------------------------------------------------------------

    //    //    //// Create a JuniorHighSchoolStudent object
    //    //    //var student = StudentHandler.ReadAJuniorHighSchoolStudent();
    //    //    //Console.WriteLine(student);
    //    //    ////----------------------------------------------------------------------------
    //    //    ///

    //    //    // Create a HighSchoolStudent object
    //    //    var student = StudentHandler.ReadAHighSchoolStudent();
    //    //    Console.WriteLine(student);
    //    //}

    //    //private void Run()
    //    //{
    //    //    //// Test 1
    //    //    //// Enter data for a Student object
    //    //    //Student student = new Student();
    //    //    //student.Id = "stu001";
    //    //    //student.Name = "Alex Ferguson";
    //    //    //student.Age = 70;
    //    //    //student.MathMark = 5.5;
    //    //    //student.LiteratureMark = 6.5;
    //    //    //student.EnglishMark = 10;

    //    //    //// Display a Student object
    //    //    //Console.WriteLine(student);
    //    //    ////------------------------------------------------------------

    //    //    //// Test 1.2
    //    //    //// Enter data for a Student object
    //    //    //Student student = new Student("stu010", "Alex Sanchez", 30, 10, 5, 7);

    //    //    //// Display a Student object
    //    //    //Console.WriteLine(student);
    //    //    ////------------------------------------------------------------

    //    //    //// Test 2
    //    //    //// Enter data for a Student object
    //    //    //var student = new PrimarySchoolStudent();
    //    //    //student.Id = "stu002";
    //    //    //student.Name = "Brad Pitt";
    //    //    //student.Age = 40;
    //    //    //student.MathMark = 7.5;
    //    //    //student.LiteratureMark = 9.5;
    //    //    //student.EnglishMark = 7;

    //    //    //// Display a Student object
    //    //    //Console.WriteLine(student);
    //    //    ////------------------------------------------------------------

    //    //    //// Test 3
    //    //    //// Enter data for a Student object
    //    //    //var student = new PrimarySchoolStudent();
    //    //    //student.Id = "stu002";
    //    //    //student.Name = "Brad Pitt";
    //    //    //student.Age = -100;
    //    //    //student.MathMark = 7.5;
    //    //    //student.LiteratureMark = 9.5;
    //    //    //student.EnglishMark = 7;

    //    //    //// Display a Student object
    //    //    //Console.WriteLine(student);
    //    //    ////------------------------------------------------------------

    //    //    //// Test 4
    //    //    //var student = new PrimarySchoolStudent("stu004", "Chris", -11, 5.5, 6.5, 10);
    //    //    //Console.WriteLine(student);
    //    //    ////------------------------------------------------------------


    //    //    //// Test 5
    //    //    //var student = new JuniorHighSchoolStudent("stu005", "Rose Mary", 15, 7.5, 8.5, 10, 5.5, 7);
    //    //    //Console.WriteLine(student);
    //    //    ////------------------------------------------------------------

    //    //    //// Test 6
    //    //    //var student = new JuniorHighSchoolStudent
    //    //    //{
    //    //    //    Id = "stu006",
    //    //    //    Name = "Hillary Clinton",
    //    //    //    Age = 11,
    //    //    //    MathMark = 9.0,
    //    //    //    LiteratureMark = 7.5,
    //    //    //    EnglishMark = 6,
    //    //    //    PhysicMark = 7,
    //    //    //    ChemistryMark = 8
    //    //    //};
    //    //    //Console.WriteLine(student);
    //    //    ////------------------------------------------------------------

    //    //    // Test 7
    //    //    //var student = new HighSchoolStudent()
    //    //    //{
    //    //    //    Id = "stu007",
    //    //    //    Name = "Bruce Willis",
    //    //    //    Age = 20,
    //    //    //    MathMark = 10,
    //    //    //    LiteratureMark = 5,
    //    //    //    EnglishMark = 10,
    //    //    //    PhysicMark = 7,
    //    //    //    ChemistryMark = 8,
    //    //    //    ComputerScienceMark = 5,
    //    //    //    FrenchMark = 6
    //    //    //};
    //    //    //Console.WriteLine(student);
    //    //    ////------------------------------------------------------------

    //    //    // Test 8
    //    //    var student = new HighSchoolStudent("stu008", "David Beckham", 10, 6, 5, 10, 8, 4, 5, 5);
    //    //    Console.WriteLine(student);
    //    //}
    //}
}
