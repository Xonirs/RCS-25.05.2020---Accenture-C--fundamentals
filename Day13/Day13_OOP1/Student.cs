using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_OOP1
{
    class Student
    {
        //private - the code (or in this case the field name) can be ONLY accessed in the SAME CLASS
        //private string name;

        //public - the code is accessible for all classes
        public string name;
        public int age;

        //when defining fields (later - also properties), we can define initial values
        public int course = 1;
        public List<int> grades = new List<int>();

        private string personalIdentityNumber;

        //Constructor - special method that is used to initialize class objects
        //              by default it is not visible and is empty
        public Student()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("A student object has been created");
            Console.ResetColor();
        }

        public Student(string _name, int _age, string _pIdNr)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("A student object has been created");
            Console.ResetColor();
            name = _name;
            age = _age;
            personalIdentityNumber = _pIdNr;
        }

        //this method is a messy approach, better use CONSTRUCTORS
        public void SetupBasicInfo(string _name, int _age, string _pIdNr)
        {
            if (string.IsNullOrEmpty(name) &&
                age == 0 &&
                string.IsNullOrEmpty(personalIdentityNumber))
            {
                name = _name;
                age = _age;
                personalIdentityNumber = _pIdNr; 
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Students name: {name} and age: {age}");
            Console.WriteLine($"Students personal identity number: {personalIdentityNumber}");
            if (grades.Count > 0)
            {
                Console.WriteLine($"Average grade: {GetAvgGrade()}");
                PrintGrades(); 
            }
            Console.WriteLine();
        }

        private void PrintGrades()
        {
            Console.WriteLine("Student grades:");
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private double GetAvgGrade()
        {
            //sum all
            var sum = 0.0;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            //divide by count
            return sum / grades.Count;
        }
    }
}
