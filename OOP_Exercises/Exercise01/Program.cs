using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
            Console.ReadLine(); // Use this to pause the program
        }

        private void Run2()
        {
            //// Initialize a Student instance
            //string id = "stu001";
            //string name = "Alex";
            ////double mathMark = -1.0;
            ////double literatureMark = 11.0;
            //double mathMark = 0.0;
            //double literatureMark = 10.0;
            //double englishMark = 5.5;
            ////Student student = new Student(id, name, mathMark, literatureMark, englishMark);
            ////Console.WriteLine(student);

            //// Initialize a PrimarySchoolStudent instance
            //string id = "stu001";
            //string name = "Alex";
            ////double mathMark = -1.0;
            ////double literatureMark = 11.0;
            //double mathMark = 0.0;
            //double literatureMark = 10.0;
            //double englishMark = 5.5;

            ////int age = -1;
            ////int age = 0;
            ////int age = 11;
            //int age = 8;
            //Student student = new PrimarySchoolStudent(id, name, age, mathMark, literatureMark, englishMark);
            //Console.WriteLine(student);

            //// Initialize a Junior High School instance
            //string id = "stu001";
            //string name = "Alex";
            ////double mathMark = -1.0;
            ////double literatureMark = 11.0;
            //double mathMark = 0.0;
            //double literatureMark = 10.0;
            //double englishMark = 5.5;

            ////int age = -1;
            ////int age = 0;
            ////int age = 8;
            //int age = 14;

            //double physicMark = 5.0;
            //double chemistryMark = 9.0;
            //Student student = new JuniorHighSchoolStudent(id, name, age, mathMark, 
            //    literatureMark, englishMark, physicMark, chemistryMark);
            //Console.WriteLine(student);

            // Initialize a High School instance
            string id = "stu001";
            string name = "Alex";
            //double mathMark = -1.0;
            //double literatureMark = 11.0;
            double mathMark = 0.0;
            double literatureMark = 10.0;
            double englishMark = 5.5;

            //int age = -1;
            //int age = 0;
            //int age = 8;
            //int age = 14;
            int age = 17;

            double physicMark = 5.0;
            double chemistryMark = 9.0;

            double computerScienceMark = 7.5;
            double frenchMark = 5.5;

            Student student = new HighSchoolStudent(id, name, age, mathMark,
                literatureMark, englishMark, physicMark, chemistryMark, computerScienceMark, frenchMark);
            Console.WriteLine(student);
        }
    }
}
