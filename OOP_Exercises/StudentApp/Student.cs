using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {
        private string id;
        private string name;
        private int age;

        public Student()
        {
        }

        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Student(string id, string name, int age) : this(id, name)
        {
            this.age = age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        override
        public string ToString()
        {
            return $"{id} - {name} - {age}";
        }
    }
}
