using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_version2
{
    internal class HighSchoolStudent : Student
    {
        // A high school student should have an age between 15 and 18.
        // If the entered age is less than 15, the age will be set to 15.
        // If the entered age is greater than 18, the age will be set to 18.
        private int age;
        public new int Age
        {
            get { return age; }
            set
            {
                if (value < 15)
                {
                    age = 15;
                }
                else if (value > 18)
                {
                    age = 18;
                }
                else
                {
                    age = value;
                }
            }
        }

        // Four specific properties: Physic mark, Chemistry mark, Computer Science mark and French mark.
        public double PhysicMark { get; set; }
        public double ChemistryMark { get; set; }
        public double ComputerScienceMark { get; set; }
        public double FrenchMark { get; set; }

        // Override the AverageMark property
        public new double AverageMark
        {
            get
            {
                return (MathMark + LiteratureMark + EnglishMark + PhysicMark + ChemistryMark + ComputerScienceMark + FrenchMark) / 7;
            }
        }

        // The default constructor
        public HighSchoolStudent()
        {
        }

        // A parameterized constructor
        public HighSchoolStudent(string id, string name, int age,
            double mathMark, double literatureMark, double englishMark,
            double physicMark, double chemistryMark,
            double computerScienceMark, double frenchMark)
        {
            Id = id;
            Name = name;
            Age = age;
            MathMark = mathMark;
            LiteratureMark = literatureMark;
            EnglishMark = englishMark;
            PhysicMark = physicMark;
            ChemistryMark = chemistryMark;
            ComputerScienceMark = computerScienceMark;
            FrenchMark = frenchMark;
        }

        // Override the ToString method
        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Age: {Age}\n\t" +
                $"Math: {MathMark} - Literature: {LiteratureMark} - English: {EnglishMark}\n\t" +
                $"Physic: {PhysicMark} - Chemistry: {ChemistryMark}\n\t" +
                $"Computer Science: {ComputerScienceMark} - French: {FrenchMark}\n\t" +
                $"Average Mark: {AverageMark:F2}";
        }
    }
}
