using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_A_List_Sample_2
{
    internal class Student : IEquatable<Student>, IComparable<Student>
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} Name: {Name}";
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Student objAsStudent = obj as Student;
            if (objAsStudent == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsStudent);
            }

        }

        // Default comparer
        public int CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.Id.CompareTo(other.Id);
            }
        }

        public bool Equals(Student other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Id.Equals(other.Id);
        }
    }
}
