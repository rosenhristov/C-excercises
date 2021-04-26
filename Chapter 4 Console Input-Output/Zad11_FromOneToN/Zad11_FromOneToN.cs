using System;

    class Zad11_FromOneToN
    {
        static void Main()
        {
            Console.Write("Insert number: ");
            int number = int.Parse(Console.ReadLine());
            int initializer = 1;
            Console.WriteLine("The numbers from 1 to 'number' are: ");
            do
            {
                Console.WriteLine("{0}", initializer);
                initializer++;
            }
            while (initializer <= number);
        }
    }
