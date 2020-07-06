using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day16_Library
{
    class BookLibrary
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private List<Book> books = new List<Book>();
        public List<Book> Books 
        {
            get { return books; }
        } 
        //auto property option:
        //public List<Books> Books { get; }


        public IEnumerable<Book> FindBookByTitle(string title)
        {
            return Books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }

        public List<Book> FindBookByAuthor(string author)
        {
            return Books.Where(b => b.Author.Name.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //validation - is the process of making sure, everything is being done correctly
        //in programming - checking if certain values are inside the expected value range
        public string AddBook(Book book)
        {
            //checking if there is a book to add
            if (book == null)
            {
                return "Book is non-existing!";
            }
            //Checking if the book.Title has a value
            if (string.IsNullOrEmpty(book.Title))
            {
                return "Book title can't be empty!";
            }
            //checking if the book has an author
            if (book.Author == null)
            {
                return "Book must have an author";
            }

            books.Add(book);

            //return "";
            return string.Empty;
        }
    }
}
