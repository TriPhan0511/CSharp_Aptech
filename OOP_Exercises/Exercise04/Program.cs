using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class Program
    {
        private BookList bookList = new BookList();
        static void Main(string[] args)
        {

            //InitializeBookList(bookList);
            //bookList.Display();

            (new Program()).Run();

        }

        private void Run()
        {
            DisplayOptions();
        }

        public void DisplayOptions()
        {
            char choice;
            do
            {
                // Menu options
                Console.WriteLine("\n-----Welcome to Book Management Application!-----\n");
                Console.WriteLine("1. Add a new book.");
                Console.WriteLine("2. Display the list of books.");
                Console.WriteLine("3. Sort the books based on author's name and display.");
                Console.WriteLine("4. Sort the books based on title and display.");
                Console.WriteLine("5. Sort the books based on publish year and display.");
                Console.WriteLine("6. Update a book based on ISBN.");
                Console.WriteLine("7. Remove a book based on ISBN.");
                Console.WriteLine("8. Exit");
                choice = Utils.ReadChar("Enter your choice: ");
                switch (choice)
                {
                    case '1':
                        //AddANewBook();
                        InitializeBookList(bookList);
                        break;
                    case '2':
                        bookList.Display();
                        break;
                    case '3':
                        bookList.SortBooksBasedOnAuthor();
                        bookList.Display();
                        break;
                    case '4':
                        bookList.SortBooksBasedOnTitle();
                        bookList.Display();
                        break;
                    case '5':
                        bookList.SortBooksBasedOnPublishYear();
                        bookList.Display();
                        break;
                    case '6':
                        UpdateABook();
                        break;
                    case '7':
                        RemoveABook();
                        break;
                    case '8':
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.Write("Wrong choice.");
                        break;
                }
            } while (choice != '8');
        }

        // Remove a book from the list.
        private void RemoveABook()
        {
            Console.WriteLine("\nPlease enter the ISBN of the book you want to remove:");
            string isbn = ReadISBNForUpdatingOrRemoving("ISBN", "e");
            if (isbn == null)
            {
                Console.WriteLine("The removing was cancelled.");
            }
            else
            {
                if (bookList.RemoveBook(isbn))
                {
                    Console.WriteLine($"The book whose ISBN is {isbn} was removed from the list.");
                }
            }
        }

        // Update a book
        private void UpdateABook()
        {
            Console.WriteLine("\nPlease enter information about the book:");
            string isbn = ReadISBNForUpdatingOrRemoving("ISBN", "e");
            if (isbn == null)
            {
                Console.WriteLine("The updating was cancelled.");
            }
            else
            {
                string title = Utils.ReadString("Title: ");
                string author = Utils.ReadString("Author: ");
                string publisher = Utils.ReadString("Publisher: ");
                int year = Utils.ReadInt("Publish Year: ");
                List<string> chapters = ReadChapters();
                if (bookList.UpdateBook(new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    Year = year,
                    ISBN = isbn,
                    Chapters = chapters
                }))
                {
                    Console.WriteLine($"The book, whose ISBN is {isbn} was updated.");
                }
            }
            
        }

        // Helper method to read ISBN from user input
        // and ensure the entered ISBN exists in the list.
        private string ReadISBNForUpdatingOrRemoving(string prompt, string escape)
        {
            string isbn;
            while (true)
            {
                isbn = Utils.ReadString(prompt + $" (Press {escape} to escape the process): ");
                if (String.Equals(isbn, escape, StringComparison.OrdinalIgnoreCase))
                {
                    return null;
                }
                else
                {
                    if (bookList.Search(isbn) == -1)
                    {
                        Console.WriteLine($"There are no book, whose ISBN is {isbn}, exists in the list. Please enter another isbn.");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return isbn;
        }

        // Add a new book
        private void AddANewBook()
        {
            Console.WriteLine("\nPlease enter information about the book:");
            string isbn = ReadISBNForAdding("ISBN", "e");
            if (isbn == null)
            {
                Console.WriteLine("The adding was cancelled.");
            }
            else
            {
                string title = Utils.ReadString("Title: ");
                string author = Utils.ReadString("Author: ");
                string publisher = Utils.ReadString("Publisher: ");
                int year = Utils.ReadInt("Publish Year: ");
                List<string> chapters = ReadChapters();
                if (bookList.AddBook(new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    Year = year,
                    ISBN = isbn,
                    Chapters = chapters
                }))
                {
                    Console.WriteLine("A new book was added.");
                }
            }
            
        }

        // Helper method to read ISBN from user input
        // and ensure the entered ISBN does not exist in the list.
        private string ReadISBNForAdding(string prompt, string escape)
        {
            string isbn;
            while (true)
            {
                isbn = Utils.ReadString(prompt + $" (Press {escape} to escape adding a new book): ");
                if (String.Equals(isbn, escape, StringComparison.OrdinalIgnoreCase))
                {
                    return null;
                }
                else
                {
                    if (bookList.Search(isbn) != -1)
                    {
                        Console.WriteLine("This isbn exists in the list. Please enter another isbn.");
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            return isbn;
        }

        // Helper method to read chapters from user input
        private static List<string> ReadChapters()
        {
            List<string> chapters = new List<string>();
            string chap;
            int i = 1;
            char keepEntering;
            do
            {
                chap = Utils.ReadString($"Enter name of chapter {i}: ");
                chapters.Add(chap);
                i++;
                keepEntering = Utils.ReadChar("Do you want to continue entering name of chapter (press c to continue or press e to escape): ");
            } while (keepEntering != 'e' && keepEntering != 'E');
            return chapters;
        }

        // Dummy data
        private static void InitializeBookList(BookList bookList)
        {
            Book book1 = new Book()
            {
                Title = "Zoo Zoo",
                Author = "Alex Ferguson",
                Publisher = "Publisher 1",
                Year = 1984,
                ISBN = "a1",
                Chapters = new List<string>() { "Chapter 1", "Chapter 2", "Chapter 3" }
            };
            Book book2 = new Book()
            {
                Title = "Yonve David",
                Author = "Brad Pit",
                Publisher = "Publisher 2",
                Year = 2021,
                ISBN = "b2",
                Chapters = new List<string>() { "Chapter 1", "Chapter 2", "Chapter 3", "Chapter 4" }
            };
            Book book3 = new Book()
            {
                Title = "Beautiful Sunday",
                Author = "Chris Peter",
                Publisher = "Publisher 3",
                Year = 1999,
                ISBN = "c3",
                Chapters = new List<string>() { "Chapter 1", "Chapter 2", "Chapter 3", "Chapter 4" }
            };
            Book book4 = new Book()
            {
                Title = "Title 4",
                Author = "David Cooperfield",
                Publisher = "Publisher 4",
                Year = 2002,
                ISBN = "d4",
                Chapters = new List<string>() { "Chapter 1", "Chapter 2", "Chapter 3", "Chapter 4", "Chapter 5", "Chapter 6" }
            };
            Book book5 = new Book()
            {
                Title = "Title 5",
                Author = "Friday Kelly",
                Publisher = "Publisher 5",
                Year = 2020,
                ISBN = "f5",
                Chapters = new List<string>() { "Chapter 1", "Chapter 2", "Chapter 3", "Chapter 4", "Chapter 5", "Chapter 6", "Chapter 7" }
            };

            bookList.AddBook(book5);
            bookList.AddBook(book2);
            bookList.AddBook(book3);
            bookList.AddBook(book1);
            bookList.AddBook(book4);
            
        }
    }
}
