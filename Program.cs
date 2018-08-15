using System;
using System.Collections.Generic;

namespace myapp.px
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Ox", "Ana", "Feli"};
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            names.Add("Mae");
            names.Add("Bill");
            names.Add("Anna");
            foreach(var name in names){
                Console.WriteLine($"Hey there {name}.");
            }
            Console.WriteLine();
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"Say hello to {names[1]} and {names[2]}");
        }
    }
}
