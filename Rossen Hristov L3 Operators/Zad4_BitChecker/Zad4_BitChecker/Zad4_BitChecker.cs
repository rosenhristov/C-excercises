using System;

    class Zad4_BitChecker
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int referentNumber = 8;

            Console.WriteLine((number & referentNumber) != 0 ? 1 : 0);
        }
    }
