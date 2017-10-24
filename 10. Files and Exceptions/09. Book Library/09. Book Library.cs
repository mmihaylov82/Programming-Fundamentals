using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;

namespace _09.Book_Library
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
                books.Add(ReadBook(inputArray[i+1]));
            }

            Library library = new Library { Name = "Library", Books = books };

            Dictionary<string, double> authors = new Dictionary<string, double>();

            foreach (var book in library.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;
                }
                else
                {
                    authors.Add(book.Author, book.Price);
                }
            }

            foreach (var pair in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                File.AppendAllText("output.txt",
                    $"{pair.Key} -> {pair.Value:F2}" + Environment.NewLine);
                //Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }

        static Book ReadBook(string input)
        {
            string[] tokens = input.Split(' ');
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releaseDate = DateTime.ParseExact(tokens[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            double price = double.Parse(tokens[5]);

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
