using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class HighSchoolStudent : Student
    {
        public HighSchoolStudent(string id, string name, int age) : base(id, name, age)
        {
            if (age < 15 || age > 18)
            {
                age = 15;
                SetAge(age);
            }
        }
    }
}
