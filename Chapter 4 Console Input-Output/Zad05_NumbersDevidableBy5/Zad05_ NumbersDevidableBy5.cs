using System;

    class Zad05_NumbersDevidableBy5
    {
        static void Main()
        {
            Console.Write("minValue = ");
            int lowerLimit = int.Parse(Console.ReadLine());
            Console.Write("maxValue = ");
            int upperLimit = int.Parse(Console.ReadLine());
            int counter = lowerLimit;

            do
            {
                counter++;
                if (counter % 5 == 0)
                {
                    Console.Write(counter + " ");
                }
            }
            while (counter <= upperLimit);
        }
    }
