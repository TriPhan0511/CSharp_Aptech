using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class PrimarySchoolStudent : Student
    {
        // A primary school student should have an age between 6 and 10.
        // If the entered age is less than 6, the age will be set to 6.
        // If the entered age is greater than 10, the age will be set to 10.
        private int age;
        public new int Age
        {
            get { return age; }
            set
            {
                if (value < 6)
                {
                    age = 6;
                }
                else if (value > 10)
                {
                    age = 10;
                }
                else
                {
                    age = value;
                }
            }
        }

        // The default constructor
        public PrimarySchoolStudent()
        {
        }

        //  A parameterized constructor
        public PrimarySchoolStudent(string id, string name, int age,
            double mathMark, double literatureMark, double englishMark)
        {
            Id = id;
            Name = name;
            Age = age; 
            MathMark = mathMark;
            LiteratureMark = literatureMark;
            EnglishMark = englishMark;
        }

        // Override the ToString method
        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Age: {Age}\n\t" +
                $"Math: {MathMark} - Literature: {LiteratureMark} - English: {EnglishMark}\n\t" +
                $"Average Mark: {AverageMark:F2}";
        }


    }
}
