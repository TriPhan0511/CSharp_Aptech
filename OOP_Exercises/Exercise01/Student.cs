using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Student
    {
        // Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double MathMark { get; set; }
        public double LiteratureMark { get; set; }
        public double EnglishMark { get; set; }
        public double AverageMark
        {
            get { return (MathMark + LiteratureMark + EnglishMark) / 3; }
        }

        // The default constructor
        public Student()
        {
        }

        // A parameterized constructor
        public Student(string id, string name, int age, 
            double mathMark, double literatureMark, double englishMark)
        {
            Id = id;
            Name = name;
            Age = age;
            MathMark = mathMark;
            LiteratureMark = literatureMark;
            EnglishMark = englishMark;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Age: {Age}\n\t" +
                $"Math: {MathMark} - Literature: {LiteratureMark} - English: {EnglishMark}\n\t" +
                $"Average Mark: {AverageMark:F2}";
        }
    }
}
