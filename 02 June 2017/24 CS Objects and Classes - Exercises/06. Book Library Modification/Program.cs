using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
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

            var givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var booksAfterDate = library.Books
            .Where(date => date.ReleaseDate > givenDate)
            .OrderBy(date => date.ReleaseDate)
            .ThenBy(title => title.Title);

            foreach (var book in booksAfterDate)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }
}
