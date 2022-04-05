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
                Console.WriteLine("3. Arrange the books based on author's name and display.");
                Console.WriteLine("4. Arrange the books based on title and display.");
                Console.WriteLine("5. Arrange the books based on publish year and display.");
                Console.WriteLine("6. Update a book based on ISBN.");
                Console.WriteLine("7. Remove a book based on ISBN.");
                Console.WriteLine("8. Exit");
                choice = Utils.ReadChar("Enter your choice: ");
                switch (choice)
                {
                    case '1':
                        AddANewBook();
                        break;
                    case '2':
                        bookList.Display();
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        Console.Write("Goodbye");
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

        private void AddANewBook()
        {
            Console.WriteLine("\nPlease enter information about the book:");
            string isbn = ReadISBN("ISBN: ");
            string title = Utils.ReadString("Title: ");
            string author = Utils.ReadString("Author: ");
            string publisher = Utils.ReadString("Publisher: ");
            int year = Utils.ReadInt("Publish Year: ");
            List<string> chapters = ReadChapters();
            bookList.AddBook(new Book()
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                Year = year,
                ISBN = isbn,
                Chapters = chapters
            });
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

        // Helper method to read ISBN from user input
        private string ReadISBN(string prompt)
        {
            string isbn;
            while (true)
            {
                isbn = Utils.ReadString(prompt);
                if (bookList.Search(isbn) != -1)
                {
                    Console.WriteLine("This isbn exists in the list. Please enter another isbn.");
                }
                else
                {
                    break;
                }
            }
            return isbn;
        }

        private static void InitializeBookList(BookList bookList)
        {
            Book book1 = new Book()
            {
                Title = "Title 1",
                Author = "Alex Ferguson",
                Publisher = "Publisher 1",
                Year = 1984,
                ISBN = "a1",
                Chapters = new List<string>() { "Chapter 1", "Chapter 2", "Chapter 3" }
            };
            Book book2 = new Book()
            {
                Title = "Title 2",
                Author = "Brad Pit",
                Publisher = "Publisher 2",
                Year = 2021,
                ISBN = "b2",
                Chapters = new List<string>() { "Chapter 1", "Chapter 2", "Chapter 3", "Chapter 4" }
            };
            Book book3 = new Book()
            {
                Title = "Title 3",
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

            bookList.AddBook(book1);
            bookList.AddBook(book2);
            bookList.AddBook(book3);
            bookList.AddBook(book4);
            bookList.AddBook(book5);
        }

        //static void Main(string[] args)
        //{
        //    //List<string> list = new List<string>();
        //    //string s1 = "ABc";
        //    //string s2 = "def";
        //    //string s3 = "XYZ";
        //    //list.Add(s1.ToLower());
        //    //list.Add(s2.ToLower());
        //    //list.Add(s3.ToLower());
        //    //Console.WriteLine(list.Contains("abc".ToLower())); // True
        //    //Console.WriteLine(list.Contains("Abc".ToLower())); // True

        //    //string s1 = "abcD";
        //    //string s2 = "Abcd";
        //    //bool b = String.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);
        //    //Console.WriteLine(b);

        //    List<string> list = new List<string>() { "Alex", "Peter", "Chris" };
        //    //Console.WriteLine(list[0]);
        //    //Console.WriteLine(list[1]);
        //    //Console.WriteLine(list[2]);

        //    list.ForEach(x => Console.WriteLine(x));

        //    list[0] = "Zozo";
        //    list.ForEach((x) => Console.WriteLine(x));
        //}
    }
}
