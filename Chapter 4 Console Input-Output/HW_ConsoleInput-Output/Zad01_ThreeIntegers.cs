using System;

    class Zad01_ThreeIntegers
    {
        static void Main()
        {
             Console.Write("Enter an integer = ");
        int integerA = int.Parse(Console.ReadLine());

        Console.Write("Enter an integer = ");
        int integerB = int.Parse(Console.ReadLine());

        Console.Write("Enter an integer = ");
        int integerC = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}",
        integerA, integerB, integerC,  integerA + integerB + integerC);
        }
    }
