using System;

    class Zad13_BitValeAlteration
    {
        static void Main()
        {
            Console.Write("Enter a number n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter a position p:  ");
            int p = Convert.ToInt32(Console.ReadLine());
            int v = 0;
            int i = 1;
            int mask = i << p;

            Console.WriteLine((n & mask) != v ? n = n & (~(1 << p)) : (n = n & mask));
        }
    }
