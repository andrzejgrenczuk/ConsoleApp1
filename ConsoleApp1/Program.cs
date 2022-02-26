using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("wpisz coś: ");
            string text = Console.ReadLine();
            Console.Write("wpisano: "+text);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            DateTime dat = DateTime.Now;
            Console.WriteLine("Today is: " + dat);
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);

        }
    }
}
