using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class HighSchoolStudent : Student
    {
        private double physicMark;
        private double chemistryMark;
        private double computerScienceMark;
        private double frenchMark;

        public HighSchoolStudent()
        {
        }

        public HighSchoolStudent(string id, string name, int age,
            double mathMark, double literatureMark, double englishMark,
            double physicMark, double chemistryMark, double computerScienceMark,
            double frenchMark) : base(id, name, mathMark, literatureMark, englishMark)
        {
            // A high school student should has an age between 15 and 18
            // if the entered age is less than 15 or greater than 18,
            // the age will be set to 15.
            if (age < 15 || age > 18)
            {
                SetAge(15);
            }
            else
            {
                SetAge(age);
            }

            SetPhysicMark(physicMark);
            SetChemistryMark(chemistryMark);
            SetComputerScienceMark(computerScienceMark);
            SetFrenchMark(frenchMark);
        }

        private void SetFrenchMark(double frenchMark)
        {
            if (frenchMark < 0.0 || frenchMark > 10.0)
            {
                this.frenchMark = 0.0;
            }
            else
            {
                this.frenchMark = frenchMark;
            }
        }

        private void SetComputerScienceMark(double computerScienceMark)
        {
            if (computerScienceMark < 0.0 || computerScienceMark > 10.0)
            {
                this.computerScienceMark = 0.0;
            }
            else
            {
                this.computerScienceMark = computerScienceMark;
            }
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

        override
        public string ToString()
        {
            string s = base.ToString();
            return s + $" - Physic: {this.physicMark} - Chemistry: {this.chemistryMark}" 
                + $" - Computer Science: {this.computerScienceMark} - French: {this.frenchMark}";
        }
    }
}
