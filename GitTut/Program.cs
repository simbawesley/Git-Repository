using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi and welcome to Git:");
            Console.WriteLine();
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Thank you {0} {1} and enjoy using this CVS",name,surname);
            Console.ReadLine();
        }
    }
}
