using System;


    class Zad06_GreaterNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer № 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter integer № 2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("The bigger number is: " + Math.Max(num1, num2));
            Console.WriteLine("The smaller number is: " + Math.Min(num1, num2));
        }
    }
