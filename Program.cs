using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Using Console.WriteLine, you can output any string to the terminal/console" + 3.14159);
        

        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }



        };
        }

        
    }
}
