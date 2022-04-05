using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class BookList
    {
        List<Book> list = new List<Book>();

        // Add a new book to a list
        public bool AddBook(Book book)
        {
            int index = Search(book.ISBN);
            if (index == 1)
            {
                return false;
            }
            list.Add(book);
            return true;
        }

        // Display a list of books
        public void Display()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\nEmpty list. Nothing to show.");
            }
            else
            {
                Console.WriteLine();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            
        }

        // Return a book with a particular isbn
        public Book GetItem(string isbn)
        {
            int index = Search(isbn);
            if (index == -1) 
            {
                return null;
            }
            return list[index];
        }

        // Remove a book based on a particular isbn
        public bool RemoveBook(string isbn)
        {
            int index = Search(isbn);
            if (index == -1)
            {
                return false;
            }
            list.RemoveAt(index);
            return true;
        }

        // Update a book
        public bool UpdateBook(Book book)
        {
            int index = Search(book.ISBN);
            if (index == -1)
            {
                return false;
            }
            list[index] = book;
            return true;
        }

        // Find the index of a specified book.
        public int Search(string isbn)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Book tempBook = list[i];
                string tempISBN = tempBook.ISBN;
                if (String.Equals(tempISBN, isbn, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
