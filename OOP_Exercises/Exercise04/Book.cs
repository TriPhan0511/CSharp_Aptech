using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class Book : IBook, IEquatable<Book>, IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public List<string> Chapters { get; set; }
        
        public override string ToString()
        {
            return $"Title: {Title} - Author: {Author} - Publisher: {Publisher}\n" +
                $"Year: {Year} - ISBN: {ISBN}\n" +
                $"Chapters:\n" + DisplayChapters(Chapters);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Book objAsBook = obj as Book;
            if (objAsBook == null)
            {
                return false;
            }
            return Equals(objAsBook);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

        public int CompareTo(Book other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.ISBN.CompareTo(other.ISBN);
            }
        }

        public bool Equals(Book other)
        {
            if (other == null)
            {
                return false;
            }
            return this.ISBN.Equals(other.ISBN);
        }

        // Helper method
        private string DisplayChapters(List<string> chapters)
        {
            String retval = "";
            foreach (var item in chapters)
            {
                retval += $"{item}\n";
            }
            return retval;
        }
    }
}
