using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BookLibrary
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

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> listOfBooks = new List<Book>();
            while (n-- > 0)
            {
                string[] inputInformation = Console.ReadLine().Split();
                string title = inputInformation[0];
                string author = inputInformation[1];
                string publisher = inputInformation[2];
                int[] dateTimeInfo = inputInformation[3].Split('.').Select(int.Parse).ToArray();
                DateTime releaseDate = new DateTime(dateTimeInfo[2], dateTimeInfo[1], dateTimeInfo[0]);
                decimal isbn = decimal.Parse(inputInformation[4]);
                decimal price = decimal.Parse(inputInformation[5]);

                Book currentBook = new Book(title, author, publisher, releaseDate, isbn, price);
                listOfBooks.Add(currentBook);

            }

            Library citySofiaLibrary = new Library("City Library of Sofia", listOfBooks);
            Dictionary<string, decimal> authorAndBooks = new Dictionary<string, decimal>();
            foreach (var book in citySofiaLibrary.ListOfBooks)
            {
                if (authorAndBooks.ContainsKey(book.Author) == false)
                {
                    authorAndBooks[book.Author] = book.Price;
                }
                else
                {
                    authorAndBooks[book.Author] += book.Price;
                }
            }
            // author = {"Tokin", "35.50"}
            foreach (var item in authorAndBooks.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }

        }
    }
}
