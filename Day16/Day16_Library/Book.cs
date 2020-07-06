namespace Day16_Library
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Press { get; set; }
        public int PageCount { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public Book()
        {

        }

        public Book(int id, string title, string isbn, Author author)
        {
            Id = id;
            Title = title;
            ISBN = isbn;
            Author = author;
        }
    }
}