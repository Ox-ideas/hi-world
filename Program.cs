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

            #region fibonacci
                var fibonacci_nos = new List<int> {1,1};

                while(fibonacci_nos.Count < 20){
                    var prev = fibonacci_nos[fibonacci_nos.Count -1];
                    var prev2 = fibonacci_nos[fibonacci_nos.Count -2];

                    fibonacci_nos.Add(prev + prev2);
                }
                // display first 20 numbers
                /*for(int i = 0; i < 20; i++){
                    Console.WriteLine(fibonacci_nos[i]);
                }*/
                foreach(var item in fibonacci_nos){
                    Console.WriteLine(item);
                }
            #endregion
        }
    }
}
