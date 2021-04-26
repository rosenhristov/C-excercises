using System;

    class Zad7_MassOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter your mass: ");
            double yourMass = Convert.ToInt32(Console.ReadLine());
            double massOnTheMoon = (double)yourMass * 0.17;
            Console.WriteLine(massOnTheMoon);
        }
    }
