using System;


    class Zad11_WriteABit
    {
        static void Main()
        {
            Console.Write("Enter value of 'n': ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of the pozition 'p': ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of the bit 'i': ");
            int i = Convert.ToInt32(Console.ReadLine()); 
            int mask = i << p;

            Console.WriteLine((n & mask) != 0 ? 1 : 0);

        }
    }
