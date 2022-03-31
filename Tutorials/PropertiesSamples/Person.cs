using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This sample demonstrates "Expression body definitions"
namespace PropertiesSamples
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string Name => $"{_firstName} {_lastName}";
    }
}
