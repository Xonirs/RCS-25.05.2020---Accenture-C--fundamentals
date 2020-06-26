using System;
using System.Collections.Generic;

namespace Day13_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student); // does nothing, just prints {namspace}.{className}

            student.name = "Bob";
            Console.WriteLine(student.name);

            student.age = 21;
            student.age = 20;
            Console.WriteLine(student.age);

            Student student2 = new Student();
            student2.name = "Ann";
            student2.age = 23;
            Console.WriteLine(student2.name);
            Console.WriteLine(student2.age);

            //instead of using those 4 WriteLine statements above, we use the class defined method
            student.PrintInfo();
            student2.PrintInfo();

            student.grades.Add(5);
            student.grades.Add(6);
            student.grades.Add(4);
            student.grades.Add(10);
            //Console.WriteLine(student.grades[0]);
            //instead of printing each grade separately, 
            //we use a student method - student.PrintGrades();

            student.PrintInfo();

            Student student3 = new Student("John", 36, "123456-12345");
            //the code we don't have to write if using constructors:
            //student3.name = "Ann";
            //student3.age = 23;
            //student3.personalIdentityNumber = 23;

            //student3.SetupBasicInfo("John", 36, "123456-12345");
            student3.PrintInfo();
            //student3.SetupBasicInfo("John2", 366, "999999-12345");
            //student3.PrintInfo();
        }
    }
}
