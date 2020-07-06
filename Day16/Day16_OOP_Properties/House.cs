using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_OOP_Properties
{
    class House
    {
        private bool isSomebodyLivingThere;

        //we would like to know, when a field is set or read
        //for this case we are using properties

        //fields - private
        //properties - public
        private string name;
        public string Name
        {
            get //read value
            {
                Console.WriteLine("Name is being read");
                return name;
            }
            set //assign value
            {
                Console.WriteLine("Name is being set");
                //'value' is the value we are trying to assign
                name = value.ToUpper();
            }
        }
        private int floors;
        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value > 0)
                {
                    floors = value;
                }
                else
                {
                    floors = 1;
                }
            }
        }

        //Default property example
        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        //automatic property
        public int Rent { get; set; }

        //read-only properties
        private string ownersName;
        public string OwnersName
        {
            get { return ownersName.ToUpper(); }
        }
        //automatic read-only property
        public string OwnersSurname { get; }

        //write-only properties
        private int electricityAmount;
        public int ElectricityAmount
        {
            set { electricityAmount = value; }
        }

        public House(string owner, string ownerSurname)
        {
            ownersName = owner;
            OwnersSurname = ownerSurname;
        }

        public void ShowInfo()
        {
            Console.WriteLine("House info.....");
            Console.WriteLine(".....");
            Console.WriteLine($"Electricity: {electricityAmount} kwh");
        }
    }
}
