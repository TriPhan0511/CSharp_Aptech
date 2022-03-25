using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class PrimarySchoolStudent : Student
    {
        public PrimarySchoolStudent(string id, string name, int age,
            double mathMark, double literatureMark, double englishMark) : base(id, name, mathMark, literatureMark, englishMark)
        {
            // A primary school student should has an age between 6 and 10
            // if the entered age is less than 6 or greater than 10,
            // the age will be set to 6.
            if (age < 6 || age > 10)
            {
                SetAge(6);
            }
            else
            {
                SetAge(age);
            }
        }
    }
}
