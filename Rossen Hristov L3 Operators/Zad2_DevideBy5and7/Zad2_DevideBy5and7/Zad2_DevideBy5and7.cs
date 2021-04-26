using System;

    class Zad2_DevideBy5and7
    {
        static void Main()
        {
            Console.Write("Please enter a value: ");
            int x = int.Parse(Console.ReadLine());
            int a = x % 5;
            int b = x % 7;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine((a == 0) && (b == 0));
        }
    }
