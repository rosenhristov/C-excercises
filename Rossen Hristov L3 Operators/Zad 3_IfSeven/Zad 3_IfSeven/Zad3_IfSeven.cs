using System;

class Zad_3_IfSeven
{
    static void Main()
    {
        Console.WriteLine("VARIANT 1 - With the use of a second variable:");
        Console.WriteLine(" ");
        Console.Write("Enter a value: ");
        int a = int.Parse(Console.ReadLine());
        int b = a / 100;
        Console.WriteLine(b % 10 == 7);

        Console.WriteLine(" ");

        Console.WriteLine("VARIANT 2 - Without the use of a second variable:");
        Console.WriteLine(" ");
        Console.Write("Enter a value: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine((x/100) % 10 == 7);
    }
}