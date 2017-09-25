using System;

namespace NetCore.Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World SC!");
            var name = System.Console.ReadLine();
            System.Console.WriteLine("Hello " +name);
            System.Console.ReadLine();

        }
    }
}