using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class ElementarySchoolStudent : Student
    {
        public ElementarySchoolStudent(string id, string name, int age) : base(id, name, age)
        {
            if (age < 11 || age > 15)
            {
                age = 11;
                SetAge(age);
            }
        }
    }
}
