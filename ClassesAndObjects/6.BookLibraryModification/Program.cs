using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _6.BookLibraryModification
{
    class Program
    {
        public class Book
        {
            public Book(string title, string author, string publisher, DateTime realeaseDate, decimal iSBN, decimal price)
            {
                Title = title;
                Author = author;
                Publisher = publisher;
                RealeaseDate = realeaseDate;
                ISBN = iSBN;
                Price = price;
            }

            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime RealeaseDate { get; set; }
            public decimal ISBN { get; set; }
            public decimal Price { get; set; }
        }

        public class Library
        {
            public string NameOfLibrary { get; set; }
            public List<Book> ListOfBooks { get; set; }

            public Library(string nameOfLibrary, List<Book> listOfBooks)
            {
                NameOfLibrary = nameOfLibrary;
                ListOfBooks = listOfBooks;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> listOfBooks = new List<Book>();
            Dictionary<string, DateTime> printTitlesByDate = new Dictionary<string, DateTime>();

            while (n-- > 0)
            {
                string[] inputInformation = Console.ReadLine().Split();
                string title = inputInformation[0];
                string author = inputInformation[1];
                string publisher = inputInformation[2];
                DateTime releaseDate = DateTime.ParseExact(inputInformation[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                decimal isbn = decimal.Parse(inputInformation[4]);
                decimal price = decimal.Parse(inputInformation[5]);

                Book currentBook = new Book(title, author, publisher, releaseDate, isbn, price);
                listOfBooks.Add(currentBook);
            }

            string date = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in listOfBooks)
            { 
                printTitlesByDate[book.Title] = book.RealeaseDate;
            }

            foreach (var title in printTitlesByDate.Where(x => x.Value > startDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{title.Key} -> {title.Value.ToString("dd.MM.yyyy")}");
            }

        }
    }
}
