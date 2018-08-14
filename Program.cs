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
        }
    }
}
