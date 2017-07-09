using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        class Library
        {
            public List<Book> Books { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public double Price { get; set; }
        }

        class AuthorSales
        {
            public string Author { get; set; }
            public double Sales { get; set; }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var library = new Library() { Books = new List<Book>() };

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                };

                library.Books.Add(book);
            }

            var authorSales = library.Books.Select(a => a.Author).Distinct()
                .Select(author => new AuthorSales
                {
                    Author = author,
                    Sales = library.Books.Where(book => book.Author == author).Sum(b => b.Price)
                })
                .OrderByDescending(AuthorSales => AuthorSales.Sales)
                .ThenBy(a => a.Author)
                .ToArray();

            foreach (var author in authorSales)
            {
                Console.WriteLine($"{author.Author} -> {author.Sales:F2}");
            }
        }
    }
}
