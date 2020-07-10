using System;

namespace Day19_Movie
{
    class Program
    {
        //In Program.Main create new Movie object and fill all 
        //values via constructor.Print all the values(where it’s 
        //possible).
        static void Main(string[] args)
        {
            Movie movie = new Movie("Avatar", 2009, 9.99, "James Cameron");
            Console.WriteLine(movie.Name);
            Console.WriteLine(movie.Year);
            Console.WriteLine(movie.Price);
        }
    }
}
