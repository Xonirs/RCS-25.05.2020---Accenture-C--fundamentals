using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_Movie
{
    //Create a class Movie. Create 4 public properties.Full property(with private field) 
    //- string Name, 
    //automatic property – int Year, read-only property – int Price, 
    //write-only property – Director.Create a constructor which will allow to set 
    //all the values(public property or private field in some cases). 
    class Movie
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year { get; set; }

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
        }

        private string director;
        public string Director
        {
            set
            {
                director = value;
            }
        }


        public Movie(string _name, int _year, double _price, string _director)
        {
            Name = _name;
            Year = _year;
            price = _price;
            Director = _director;
        }
    }
}
