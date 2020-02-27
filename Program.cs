using System;

namespace numbersincsharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // addition
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            //WorkingWithIntegers();
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
                    
            Console.WriteLine(d);
        }
    }
}
