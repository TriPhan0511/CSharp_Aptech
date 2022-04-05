using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        // The default constructor
        public Student()
        {
        }

        // A parameterized constructor
        public Student(string id, string name, string phoneNumber, string address)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // Override the ToString method
        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Phone Number: {PhoneNumber} - Address: {Address}";
        }
    }
}
