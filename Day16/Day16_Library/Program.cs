using System;
using System.Collections.Generic;

namespace Day16_Library
{
    class Program
    {
        //Create an application for Library. Library can contain multiple Books. Each book has an Author.
        //At Library you can find books after book name or author. Create a console application and create library
        //with multiple books and their authors. Use book search both by name and author.
        static void Main(string[] args)
        {
            BookLibrary library = new BookLibrary();
            Author author1 = new Author(1, "Bob", "Pinetree", "Dark maze");
            Author author2 = new Author(2, "Maria", "Kerlfield", "Rainbow");
            Author author3 = new Author(3, "Richie", "Moonstone", "Rainbow");
            Book book1 = new Book(1, "Adventures of little coder", "ISBN-XCVF", author1);
            Book book2 = new Book(2, "Pride and prejudice", "ISBN-XFVF", author1);
            Book book3 = new Book(3, "Harry Potter and the covid19", "ISBN-XGVF", author2);
            Book book4 = new Book(4, "Life after Covid", "ISBN-XHVF", author2);
            Book book5 = new Book(5, "Mockingbird", "ISBN-XHVF", author3);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            IEnumerable<Book> books1 = library.FindBookByTitle("co");
            List<Book> books2 = library.FindBookByAuthor("ri");

            Console.WriteLine("Book search by title:");
            foreach (var book in books1)
            {
                Console.WriteLine($"Book title: {book.Title}");
            }

            Console.WriteLine("Book search by author:");
            foreach (var book in books2)
            {
                Console.WriteLine($"Book title: {book.Title}");
            }
        }
    }
}
