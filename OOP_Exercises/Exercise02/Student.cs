using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class Student
    {
        private int id;
        private string name;
        private string phoneNumber;
        private string address;

        public Student()
        {
        }

        public Student(int id, string name, string phoneNumber, string address)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }
    }
}
