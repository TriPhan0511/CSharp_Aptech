using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal abstract class Student
    {
        private string id; 
        private string name;
        private int age;
        private double mathMark;
        private double literatureMark;
        private double englishMark;

        public Student() { }

        public Student(string id, string name,
            double mathMark, double literatureMark, double englishMark)
        {
            this.id = id;
            this.name = name;
            SetMathMark(mathMark);
            SetLiteratureMark(literatureMark);
            SetEnglishMark(englishMark);
        }

        public abstract double CalculateAverageMark();

        public double GetMathMark()
        {
            return this.mathMark;
        }

        public double GetLiteratureMark()
        {
            return this.literatureMark;
        }

        public double GetEnglishMark()
        {
            return this.englishMark;
        }

        public void SetEnglishMark(double englishMark)
        {
            if (englishMark < 0.0 || englishMark > 10.0)
            {
                this.englishMark = 0.0;
            }
            else
            {
                this.englishMark = englishMark;
            }
        }
        public void SetLiteratureMark(double literatureMark)
        {
            if (literatureMark < 0.0 || literatureMark > 10.0)
            {
                this.literatureMark = 0.0;
            }
            else
            {
                this.literatureMark = literatureMark;
            }
        }
        public void SetMathMark(double mathMark)
        {
            if (mathMark < 0.0 || mathMark > 10.0)
            {
                this.mathMark = 0.0;
            }
            else
            {
                this.mathMark = mathMark;
            }
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        
        public override string ToString()
        {
            return $"ID: {this.id}" +
                $" - Name: {this.name}" +
                $" - Age: {this.age}" +
                $" - Math: {this.mathMark}" +
                $" - Literature: {this.literatureMark}" +
                $" - English: {this.englishMark}";
                
        }
    }
}
