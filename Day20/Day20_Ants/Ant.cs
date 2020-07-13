using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_Ants
{
    //Ant has public properties - Name, Size, and a public method void WorkerSound(), which prints “WORK WORK WORK”.
    class Ant
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public void WorkerSound()
        {
            Console.WriteLine("WORK WORK WORK");
        }
    }
}
