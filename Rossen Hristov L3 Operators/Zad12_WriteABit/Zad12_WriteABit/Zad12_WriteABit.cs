using System;

    class Zad12_WriteABit
    {
        static void Main()
        {
            Console.Write("Enter a value of number \"v\": ");
            int v = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a value of position \"p\": ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a value of \"i\": ");
            int i = Convert.ToInt32(Console.ReadLine());
            
            int changedV = i << p;

            Console.WriteLine((v & changedV) != 0 ? "true" : "false");
        }
    }
