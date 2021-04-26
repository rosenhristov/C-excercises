using System;

    class Zad10_SumOfNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("n1 = ");
            int num1 = int.Parse(Console.ReadLine());
            int sum = numberN + num1;
            Console.Write("n2 = ");
            int num2 = int.Parse(Console.ReadLine());
            sum += num2;
            Console.Write("n3 = ");
            int num3 = int.Parse(Console.ReadLine());
            sum += num3;
            Console.Write("n4 = ");
            int num4 = int.Parse(Console.ReadLine());
            sum += num4;
            Console.WriteLine("The sum of the five integers is: " + sum);
        }
    }