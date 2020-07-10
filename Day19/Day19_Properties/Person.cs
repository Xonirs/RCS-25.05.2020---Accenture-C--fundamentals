using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_Properties
{
    class Person
    {
        //Properties help us achieve Encapsulation
        //Encapsulation - is to make sure to hide "sensitive" data/information from users
        //which is achieved by having fields private and properties public

        //full-property
        private string name; // field
        public string Name //Property
        {
            get //is used to read the value
            {
                Console.WriteLine("Name is being read");
                return name;
            }
            set //is used to assign the value
            {
                Console.WriteLine("Name is being set");
                name = value; //value - a special keyword, which contains the new value being set
            }
        }

        //automatic property
        public string Surname { get; set; }

        //Read-Only property
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
        }

        //Read-Only property
        private int pianoExp;
        public int PianoExp
        {
            get
            {
                int exp = pianoExp * pianoExp + 7;
                return exp;
            }
        }

        //automatic read-only property
        public int Cats { get; }

        //Write-Only property
        private bool scaredOfSpider;
        public bool ScaredOfSpider
        {
            set
            {
                scaredOfSpider = value;
            }
        }

        //automatic public-read private-set property
        //this means that MothersName can be read anywhere, also outside this class
        //but the value, can be set only inside this class
        public string MothersName { get; private set; }

        //constructor
        public Person()
        {

        }

        public Person(int _age)
        {
            age = _age;
            pianoExp = _age / 2;
        }

        public Person(string mothersName)
        {

        }
    }
}
