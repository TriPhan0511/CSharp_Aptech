using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class PrimarySchoolStudent : Student
    {
        public PrimarySchoolStudent(string id, string name, int age) : base(id, name)
        {
            if (age < 6 || age > 14)
            {
                age = 6;
                SetAge(age);
            }
        }
    }
}
