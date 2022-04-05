using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class StudentHandler
    {
        public static Student ReadAStudent()
        {
            string id = Utils.ReadString("Enter an id: ");
            string name = Utils.ReadString("Enter a name: ");
            string phoneNumber = Utils.ReadString("Enter a phone number: ");
            string address = Utils.ReadString("Enter an address: ");
            return new Student(id, name, phoneNumber, address);
        }
    }
}
