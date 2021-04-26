using System;

    class Zad13_VariableValueExchange
    {
        static void Main()
        {
            Console.WriteLine("Variant 1");
            int x = 5;
            int y = 10;
            int z = x + y;
            x = z - x;
            y = z - y;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine(" ");
            Console.WriteLine("Variant 2");

            int a = 5;
            int b = 10;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
