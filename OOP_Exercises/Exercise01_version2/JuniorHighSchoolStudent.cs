using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_version2
{
    internal class JuniorHighSchoolStudent : Student
    {
        // A junior high school student should have an age between 11 and 15.
        // If the entered age is less than 11, the age will be set to 11.
        // If the entered age is greater than 15, the age will be set to 15.
        private int age;
        public new int Age
        {
            get { return age; }
            set
            {
                if (value < 11)
                {
                    age = 11;
                }
                else if (value > 15)
                {
                    age = 15;
                }
                else
                {
                    age = value;
                }
            }
        }

        // Two specific properties: physic mark and chemistry mark
        public double PhysicMark { get; set; }
        public double ChemistryMark { get; set; }

        // Override the AverageMark property
        public new double AverageMark
        {
            get
            {
                return (MathMark + LiteratureMark + EnglishMark + PhysicMark + ChemistryMark) / 5;
            }
        }

        // The default constructor
        public JuniorHighSchoolStudent()
        {
        }

        // A parameterized constructor
        public JuniorHighSchoolStudent(string id, string name, int age,
            double mathMark, double literatureMark, double englishMark,
            double physicMark, double chemistryMark)
        {
            Id = id;
            Name = name;
            Age = age;
            MathMark = mathMark;
            LiteratureMark = literatureMark;
            EnglishMark = englishMark;
            PhysicMark = physicMark;
            ChemistryMark = chemistryMark;
        }

        // Override the ToString method
        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Age: {Age}\n\t" +
                $"Math: {MathMark} - Literature: {LiteratureMark} - English: {EnglishMark}\n\t" +
                $"Physic: {PhysicMark} - Chemistry: {ChemistryMark}\n\t" +
                $"Average Mark: {AverageMark:F2}";
        }
    }
}
