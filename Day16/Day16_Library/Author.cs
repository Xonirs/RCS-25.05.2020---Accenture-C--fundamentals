using System.Collections.Generic;

namespace Day16_Library
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public string Pseudonym { get; set; }

        public Author()
        {

        }

        public Author(int id, string name, string surname, string pseudonym)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Pseudonym = pseudonym;
        }
    }
}