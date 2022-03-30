using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class JuniorHighSchoolStudent : Student
    {
        private double physicMark;
        private double chemistryMark;

        public JuniorHighSchoolStudent()
        {
        }

        public JuniorHighSchoolStudent(string id, string name, int age,
            double mathMark, double literatureMark, double englishMark,
            double physicMark, double chemistryMark) : base(id, name, mathMark, literatureMark, englishMark)
        {
            // A junior high school student should has an age between 11 and 15
            // if the entered age is less than 11 or greater than 15,
            // the age will be set to 11.
            if (age < 11 || age > 15)
            {
                SetAge(11);
            }
            else
            {
                SetAge(age);
            }
            SetPhysicMark(physicMark);
            SetChemistryMark(chemistryMark);
        }


        public override double CalculateAverageMark()
        {
            return (GetMathMark() + GetLiteratureMark() + GetEnglishMark() 
                + GetPhysicMark() + GetChemistryMark()) / 5;
        }

        public double GetChemistryMark()
        {
            return this.chemistryMark;
        }

        public double GetPhysicMark()
        {
            return this.physicMark;
        }

        private void SetChemistryMark(double chemistryMark)
        {
            if (chemistryMark < 0.0 || chemistryMark > 10.0)
            {
                this.chemistryMark = 0.0;
            }
            else
            {
                this.chemistryMark = chemistryMark;
            }
        }

        private void SetPhysicMark(double physicMark)
        {
            if (physicMark < 0.0 || physicMark > 10.0)
            {
                this.physicMark = 0.0;
            }
            else
            {
                this.physicMark = physicMark;
            }
        }

        public override string ToString()
        {
            return base.ToString()
                + $" - Physic: {this.physicMark} - Chemistry: {this.chemistryMark}"
                + $" - Average mark: {CalculateAverageMark()}"; 
        }
    }
}
