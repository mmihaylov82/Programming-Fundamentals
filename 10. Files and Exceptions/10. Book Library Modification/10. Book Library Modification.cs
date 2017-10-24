using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

namespace _05.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            int n = int.Parse(inputArray[0]);
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                books.Add(ReadBook(inputArray[i + 1]));
            }

            Library library = new Library { Name = "Library", Books = books };

            Dictionary<string, DateTime> releasedBooks = new Dictionary<string, DateTime>();

            DateTime referenceDate = DateTime.ParseExact(
                inputArray[n + 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Books)
            {
                if (book.ReleaseDate.CompareTo(referenceDate) > 0)
                {
                    releasedBooks.Add(book.Title, book.ReleaseDate);
                }
            }

            foreach (var pair in releasedBooks
                .Where(x => x.Value > referenceDate)
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key))
            {
                File.AppendAllText("output.txt", 
                    $"{pair.Key} -> {pair.Value:dd.MM.yyyy}" + Environment.NewLine);
            }
        }

        static Book ReadBook(string input)
        {
            string[] inputArgs = input.Split(' ');
            string title = inputArgs[0];
            string author = inputArgs[1];
            string publisher = inputArgs[2];
            DateTime releaseDate = DateTime.ParseExact(inputArgs[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            string isbn = inputArgs[4];
            double price = double.Parse(inputArgs[5]);

            return new Book
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ReleaseDate = releaseDate,
                ISBN = isbn,
                Price = price
            };
        }
    }
}