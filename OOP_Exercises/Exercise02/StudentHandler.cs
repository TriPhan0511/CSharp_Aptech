using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class StudentHandler
    {
        public Student ReadAStudent()
        {
            string id = Utils.ReadString("Enter an id: ");
            string name = Utils.ReadString("Enter a name: ");
            string phoneNumber = Utils.ReadString("Enter a phone number: ");
        }
    }
}
