using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_App
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your name");

            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("How old are you? ");
            string age = Console.ReadLine();
            Console.WriteLine("You are " + age + " old.");
        }
    }
}
