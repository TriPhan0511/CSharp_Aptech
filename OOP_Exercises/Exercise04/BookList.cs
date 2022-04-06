using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class BookList
    {
        private List<Book> list = new List<Book>();

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

        // Sort the list based on publish year
        public void SortBooksBasedOnPublishYear()
        {
            list.Sort(delegate (Book b1, Book b2)
            {
                return b1.Year.CompareTo(b2.Year);
            });
        }

        // Sort the list based on title
        public void SortBooksBasedOnTitle()
        {
            list.Sort(delegate (Book b1, Book b2)
            {
                if (b1.Title == null && b2.Title == null)
                {
                    return 0;
                }
                else if (b1.Title == null)
                {
                    return -1;
                }
                else if (b2.Title == null)
                {
                    return 1;
                }
                else
                {
                    return b1.Title.CompareTo(b2.Title);
                }
            });
        }

        // Sort the list based on author
        public void SortBooksBasedOnAuthor()
        {
            list.Sort(delegate (Book b1, Book b2)
            {
                if (b1.Author == null && b2.Author == null)
                {
                    return 0;
                }
                else if (b1.Author == null)
                {
                    return -1;
                }
                else if (b2.Author ==  null)
                {
                    return 1;
                }
                else
                {
                    return b1.Author.CompareTo(b2.Author);
                }
            });
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
